using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using RestArk.Core.Entities;
using RestArk.Core.Repositories;

namespace RestArk.Data.Repositories
{
    internal class PlayerRepository : RepositoryBase, IPlayerRepository
    {
        public PlayerRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public Task AddAsync(Player entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Player> FindBySteamIdAsync(long steamId)
        {
            var sql = "SELECT * FROM players WHERE SteamId = @SteamId";
            var param = new { SteamId = steamId };

            return await QueryFirstOrDefaultAsync<Player>(sql, param);
        }

        public async Task UpdatePermissionGroupsAsync(long steamId, string permissionGroups)
        {
            Console.WriteLine($"updating permissiongroups: {permissionGroups}");
            var sql = @"UPDATE players SET PermissionGroups = @PermissionGroups WHERE SteamId = @SteamId";
            var param = new { SteamId = steamId, PermissionGroups = permissionGroups };

            await ExecuteAsync(sql, param);
        }

        public async Task<IEnumerable<Player>> GetAllAsync()
        {
            var sql = "SELECT * FROM players";

            return await QueryAsync<Player>(sql);
        }

        public async Task<Player> GetAsync(long key)
        {
            var sql = "SELECT * FROM players WHERE id = @Key";
            var param = new { Key = key };

            return await QueryFirstOrDefaultAsync<Player>(sql, param);
        }

        public async Task RemoveAsync(long key)
        {
            var sql = "DELETE FROM players WHERE id = @Key";
            var param = new { Key = key };

            await ExecuteAsync(sql, param);
        }

        public async Task UpdateAsync(Player entity)
        {
            var sql = @"UPDATE players SET PermissionGroups = @PermissionGroups WHERE Id = @Id";

            await ExecuteAsync(sql, entity);
        }
    }
}
