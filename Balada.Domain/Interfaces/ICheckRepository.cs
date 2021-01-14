using Balada.Domain.Entities;
using System.Threading.Tasks;

namespace Balada.Domain.Interfaces
{
    public interface ICheckRepository : IGenericRepository<Check>
    {
        Task<Check> GetCheckByUserId(int id);
    }
}
