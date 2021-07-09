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
    [Route("/api/shop")]
    public class ShopController : Controller
    {
        private readonly IShopService shopService;

        public ShopController(IShopService shopService)
        {
            this.shopService = shopService;
        }

        [HttpGet("/api/users/{id}/shop")]
        public async Task<ArkShopPlayer> GetUserShopAsync(long id)
        {
            var shop = await shopService.GetUserShopAsync(id);

            return shop;
        }
    }
}
