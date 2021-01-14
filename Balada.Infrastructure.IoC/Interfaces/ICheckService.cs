using Balada.Infrastructure.IoC.Models.Check;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Balada.Infrastructure.IoC.Interfaces
{
    public interface ICheckService
    {
        Task CreateAsync(CheckRequestModel entity);
        Task<CheckResponseModel> GetByIdAsync(int id);
        Task<List<CheckResponseModel>> GetAllAsync();
        Task UpdateAsync(int id, CheckUpdateModel entity);
        Task DeleteAsync(int id);
    }
}
