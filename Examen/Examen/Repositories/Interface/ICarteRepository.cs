using Examen.Models.Domain;

namespace Examen.Repositories.Interface
{
    public interface ICarteRepository
    {
        Task<Carte?> GetCarteById(Guid id);
        Task<Carte> CreateAsync(Carte carte);
        Task<IEnumerable<Carte>> GetAllAsync();
    }
}
