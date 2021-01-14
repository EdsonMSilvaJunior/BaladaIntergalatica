using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
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
            return await _dbSet.FirstOrDefaultAsync(x => x.AlienId == id);
        }
    }
}
