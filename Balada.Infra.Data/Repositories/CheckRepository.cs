using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Balada.Infra.Data.Repositories
{
    public class CheckRepository : GenericRepository<Check>, ICheckRepository
    {
        public CheckRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<Check> GetCheckByUserId(int id)
        {
            var entity = await _dbSet.FirstOrDefaultAsync(x => x.AlienId == id);
            if (entity == null || entity.Deleted)
            {
                throw new Exception("Id não encontrado.");
            }
            return entity;
        }
    }
}
