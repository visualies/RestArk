using RestArk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestArk.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPlayerRepository PlayerRepository { get; }
        IArkShopPlayerRepository ArkShopPlayerRepository { get; }
        IAdvancedAchievementsRepository AdvancedAchievementsRepository { get; }
        IPermissionGroupRepository PermissionGroupRepository { get; }

        void Commit();
    }
}
