using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Kaos.Data.Repositories;
using MySql.Data.MySqlClient;
using RestArk.Core.Entities;
using RestArk.Core;
using RestArk.Core.Repositories;
using RestArk.Data.Repositories;

namespace RestArk.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IDbConnection connection;
        private IDbTransaction transaction;
        private IPlayerRepository playerRepository;
        private IArkShopPlayerRepository arkShopPlayerRepository;
        private IPermissionGroupRepository permissionGroupRepository;
        private IAdvancedAchievementsRepository advancedAchievementsRepository;
        private bool disposed;

        public UnitOfWork(BaseConfig config)
        {
            connection = new MySqlConnection(config.Connection.GetConnectionString());
            connection.Open();
            transaction = connection.BeginTransaction();
        }

        public IPlayerRepository PlayerRepository
        {
            get
            {
                return playerRepository ?? (playerRepository = new PlayerRepository(transaction));
            }
        }

        public IArkShopPlayerRepository ArkShopPlayerRepository
        {
            get
            {
                return arkShopPlayerRepository ?? (arkShopPlayerRepository = new ArkShopPlayerRepository(transaction));
            }
        }

        public IAdvancedAchievementsRepository AdvancedAchievementsRepository
        {
            get
            {
                return advancedAchievementsRepository ?? (advancedAchievementsRepository = new AdvancedAchievementsRepository(transaction));
            }
        }

        public IPermissionGroupRepository PermissionGroupRepository
        {
            get
            {
                return permissionGroupRepository ?? (permissionGroupRepository = new PermissionGroupRepository(transaction));
            }
        }

        public void Commit()
        {
            try
            {
                transaction.Commit();
            }
            catch
            {
                transaction.Rollback();
            }
            finally
            {
                transaction.Dispose();
                ResetRepositories();
                transaction = connection.BeginTransaction();
            }
        }

        public void Dispose()
        {
            dispose(true);
            GC.SuppressFinalize(this);
        }

        #region Private Methods
        private void ResetRepositories()
        {
            playerRepository = null;
            arkShopPlayerRepository = null;
            advancedAchievementsRepository = null;
            permissionGroupRepository = null;
        }

        private void dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                        transaction = null;
                    }
                    if (connection != null)
                    {
                        connection.Dispose();
                        connection = null;
                    }
                }
                disposed = true;
            }
        }

        ~UnitOfWork()
        {
            dispose(false);
        }
        #endregion
    }
}
