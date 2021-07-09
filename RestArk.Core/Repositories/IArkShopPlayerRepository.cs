using RestArk.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Core.Repositories
{
    public interface IArkShopPlayerRepository : IBaseRepository<ArkShopPlayer, long>
    {
        Task<ArkShopPlayer> FindBySteamIdAsync(long steamId);
    }
}
