using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestArk.Core.Entities;
using RestArk.Core.Services;

namespace RestArk.Api.Controllers
{
    [ApiController]
    [Route("/api/users")]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<User> Get(long id)
        {
            var user = await userService.GetUserAsync(id);

            return user;
        }
    }
}
