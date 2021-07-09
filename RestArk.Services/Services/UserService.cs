using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using RestArk.Core;
using RestArk.Core.Entities;
using RestArk.Core.Services;

namespace RestArk.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork context;

        public UserService(IUnitOfWork context)
        {
            this.context = context;
        }
        public async Task<User> GetUserAsync(long steamId)
        {
            try
            {
                var player = await context.PlayerRepository.FindBySteamIdAsync(steamId);

                var user = new User
                {
                    Id = player.SteamId,
                };

                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
