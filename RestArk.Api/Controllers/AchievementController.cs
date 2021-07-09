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
    [Route("/api/users/{id}/achievements")]
    public class AchievementController : Controller
    {
        private readonly IAchievementService achievementService;

        public AchievementController(IAchievementService achievementService)
        {
            this.achievementService = achievementService;
        }

        [HttpGet]
        public async Task<AdvancedAchievement> Get(long id)
        {
            var achievements = await achievementService.GetAchievementsAsync(id);

            return achievements;
        }
    }
}
