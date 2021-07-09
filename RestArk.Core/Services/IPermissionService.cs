using RestArk.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestArk.Core.Services
{
    public interface IPermissionService
    {
        Task<IEnumerable<PermissionGroup>> GetPermissionGroupsAsync();
        Task<IEnumerable<string>> GetUserPermissionGroupsAsync(long steamId);
        Task UpdateUserPermissionGroupsAsync(long steamId, IEnumerable<string> permissions);
    }
}