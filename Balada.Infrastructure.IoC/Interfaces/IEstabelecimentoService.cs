using Balada.Domain.Entities;
using Balada.Infrastructure.IoC.Models.Estabelecimentos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Interfaces
{
    public interface IEstabelecimentoService
    {
        Task<int> CreateAsync(EstabelecimentoRequestModel estabelecimentoRequestModel);
        Task<EstabelecimentoResponseModel> GetByIdAsync(int id);
        Task<List<EstabelecimentoResponseModel>> GetAllAsync();
        Task UpdateAsync(int id, EstabelecimentoUpdateModel estabelecimentoUpdateModel);
        Task DeleteAsync(int id);

    }
}
