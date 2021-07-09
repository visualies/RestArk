using RestArk.Core.Entities;
using System.Threading.Tasks;

namespace RestArk.Core.Services
{
    public interface IShopService
    {
        Task<ArkShopPlayer> GetUserShopAsync(long steamId);
    }
}