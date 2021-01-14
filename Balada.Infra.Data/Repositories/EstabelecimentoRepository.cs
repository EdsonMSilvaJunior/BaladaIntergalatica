using Balada.Domain.Entities;
using Balada.Domain.Interfaces;
using Balada.Infra.Data.Context;

namespace Balada.Infra.Data.Repositories
{
    public class EstabelecimentoRepository : GenericRepository<Estabelecimento>, IEstabelecimentoRepository
    {
        public EstabelecimentoRepository(AppDbContext dbContext) : base(dbContext)
        {
          
        }
    }
}
