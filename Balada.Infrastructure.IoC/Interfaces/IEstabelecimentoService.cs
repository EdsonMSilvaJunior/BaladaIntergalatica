using Balada.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Interfaces
{
    public interface IEstabelecimentoService
    {
        Task<int> CreateAsync(Estabelecimento entity);
        Task<Estabelecimento> GetByIdAsync(int id);
        Task<List<Estabelecimento>> GetAllAsync();
        Task UpdateAsync(int id, Estabelecimento entity);
        Task DeleteAsync(int id);

    }
}
