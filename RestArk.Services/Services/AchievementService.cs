using RestArk.Core;
using RestArk.Core.Entities;
using RestArk.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Services.Services
{
    public class AchievementService : IAchievementService
    {
        private readonly IUnitOfWork context;

        public AchievementService(IUnitOfWork context)
        {
            this.context = context;
        }

        public async Task<AdvancedAchievement> GetAchievementsAsync(long steamId)
        {
            var achievement = await context.AdvancedAchievementsRepository.FindBySteamIdAsync(steamId);

            return achievement;
        }
    }
}
