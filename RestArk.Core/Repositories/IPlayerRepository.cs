using RestArk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Core.Repositories
{
    public interface IPlayerRepository : IBaseRepository<Player, long>
    {
        Task<Player> FindBySteamIdAsync(long steamId);
        Task UpdatePermissionGroupsAsync(long steamId, string permissionGroups);
    }
}
