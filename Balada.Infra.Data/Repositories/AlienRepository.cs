using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infra.Data.Context;

namespace Balada.Infra.Data.Repositories
{
    public class AlienRepository : GenericRepository<Alien>, IAlienRepository
    {
        public AlienRepository(AppDbContext dbContext) : base (dbContext)
        {
           
        }
    }
}
