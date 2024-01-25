using Examen.Models.Domain;

namespace Examen.Repositories.Interface
{
    public interface IAutorRepository
    {
        Task<Autor?> GetAutorById(Guid id);
        Task<Autor> CreateAsync(Autor autor);
        Task<IEnumerable<Autor>> GetAllAsync();
    }
}
