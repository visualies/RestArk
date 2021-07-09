using RestArk.Core.Entities;
using RestArk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Data.Repositories
{
    internal class AdvancedAchievementsRepository : RepositoryBase, IAdvancedAchievementsRepository
    {
        public AdvancedAchievementsRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public async Task<AdvancedAchievement> FindBySteamIdAsync(long steamId)
        {
            var sql = "SELECT * FROM advancedachievements_playerdata WHERE SteamId = @SteamId";
            var param = new { SteamId = steamId };

            return await QueryFirstOrDefaultAsync<AdvancedAchievement>(sql, param);
        }

        public Task AddAsync(AdvancedAchievement entity)
        {
            throw new NotImplementedException();
        }


        public Task<IEnumerable<AdvancedAchievement>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<AdvancedAchievement> GetAsync(long key)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(long key)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(AdvancedAchievement entity)
        {
            throw new NotImplementedException();
        }
    }
}
