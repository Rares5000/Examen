using Examen.Models.Domain;
using Examen.Models.DTO;

namespace Examen.Repositories.Interface
{
    public interface IEdituraRepository
    {
        Task<Editura> CreateAsync(Editura editura);
        Task<IEnumerable<Editura>> GetAllAsync();
    }
}
