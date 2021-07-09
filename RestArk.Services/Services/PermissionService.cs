using RestArk.Core;
using RestArk.Core.Entities;
using RestArk.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IUnitOfWork context;

        public PermissionService(IUnitOfWork context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<PermissionGroup>> GetPermissionGroupsAsync()
        {
            var perms = await context.PermissionGroupRepository.GetAllAsync();

            return perms;
        }

        public async Task<IEnumerable<string>> GetUserPermissionGroupsAsync(long steamId)
        {
            var player = await context.PlayerRepository.FindBySteamIdAsync(steamId);
            var perms = player.PermissionGroups.Split(',').Where(s => !string.IsNullOrWhiteSpace(s));

            return perms;
        }

        public async Task UpdateUserPermissionGroupsAsync(long steamId, IEnumerable<string> permissions)
        {
            var permissionGroups = $"{string.Join(',', permissions)},";

            await context.PlayerRepository.UpdatePermissionGroupsAsync(steamId, permissionGroups);

            context.Commit();
        }
    }
}
