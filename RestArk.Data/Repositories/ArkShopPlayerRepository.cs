using RestArk.Core.Entities;
using RestArk.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace RestArk.Data.Repositories
{
    internal class ArkShopPlayerRepository : RepositoryBase, IArkShopPlayerRepository
    {
        public ArkShopPlayerRepository(IDbTransaction transaction) : base(transaction)
        {

        }
        public Task AddAsync(ArkShopPlayer entity)
        {
            throw new NotImplementedException();
        }

        public async Task<ArkShopPlayer> FindBySteamIdAsync(long steamId)
        {
            var sql = "SELECT * FROM arkshopplayers WHERE SteamId = @SteamId";
            var param = new { SteamId = steamId };

            return await QueryFirstOrDefaultAsync<ArkShopPlayer>(sql, param);
        }

        public Task<IEnumerable<ArkShopPlayer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ArkShopPlayer> GetAsync(long key)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(long key)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ArkShopPlayer entity)
        {
            throw new NotImplementedException();
        }
    }
}
