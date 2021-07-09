using RestArk.Core;
using RestArk.Core.Entities;
using RestArk.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Services.Services
{
    public class ShopService : IShopService
    {
        private readonly IUnitOfWork context;

        public ShopService(IUnitOfWork context)
        {
            this.context = context;
        }
        public async Task<ArkShopPlayer> GetUserShopAsync(long steamId)
        {
            var shop = await context.ArkShopPlayerRepository.FindBySteamIdAsync(steamId);

            return shop;
        }
    }
}
