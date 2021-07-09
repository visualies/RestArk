using RestArk.Core.Entities;
using System.Threading.Tasks;

namespace RestArk.Core.Services
{
    public interface IAchievementService
    {
        Task<AdvancedAchievement> GetAchievementsAsync(long steamId);
    }
}