using RestArk.Core.Entities;
using RestArk.Core.Repositories;
using RestArk.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Kaos.Data.Repositories
{
    internal class PermissionGroupRepository : RepositoryBase, IPermissionGroupRepository
    {
        public PermissionGroupRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public Task AddAsync(PermissionGroup entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PermissionGroup>> GetAllAsync()
        {
            var sql = "SELECT * FROM permissiongroups";

            return await QueryAsync<PermissionGroup>(sql);
        }

        public async Task<PermissionGroup> GetAsync(long key)
        {
            var sql = "SELECT * FROM players WHERE id = @Key";
            var param = new { Key = key };

            return await QueryFirstOrDefaultAsync<PermissionGroup>(sql, param);
        }

        public Task RemoveAsync(long key)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PermissionGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
