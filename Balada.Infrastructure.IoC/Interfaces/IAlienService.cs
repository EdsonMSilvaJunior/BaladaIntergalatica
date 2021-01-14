using Balada.Domain.Entities;
using Balada.Infrastructure.IoC.Models.Aliens;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Interfaces
{
    public interface IAlienService
    {
        Task<int> CreateAsync(AlienRequestModel entity);
        Task<AlienResponseModel> GetByIdAsync(int id);
        Task<List<AlienResponseModel>> GetAllAsync();
        Task UpdateAsync(int id, AlienUpdateModel entity);
        Task DeleteAsync(int id);
    }
}
