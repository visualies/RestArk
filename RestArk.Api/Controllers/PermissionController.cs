using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestArk.Core.Entities;
using RestArk.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestArk.Api.Controllers
{
    [ApiController]
    [Route("/api/permissions")]
    public class PermissionController : Controller
    {
        private readonly IPermissionService permissionService;

        public PermissionController(IPermissionService permissionService)
        {
            this.permissionService = permissionService;
        }

        [HttpGet]
        public async Task<IEnumerable<PermissionGroup>> Get()
        {
            var permissions = await permissionService.GetPermissionGroupsAsync();

            return permissions;
        }

        [HttpGet("/api/users/{id}/permissions")]
        public async Task<IEnumerable<string>> GetUserPermissionsAsync(long id)
        {
            var permissions = await permissionService.GetUserPermissionGroupsAsync(id);

            return permissions;
        }

        [HttpPut("/api/users/{id}/permissions")]
        public async Task Update(long id, IEnumerable<string> permissions)
        {
            await permissionService.UpdateUserPermissionGroupsAsync(id, permissions);
        }
    }
}
