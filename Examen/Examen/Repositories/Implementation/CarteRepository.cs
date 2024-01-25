using Examen.Data;
using Examen.Models.Domain;
using Examen.Repositories.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.Implementation
{
    public class CarteRepository : ICarteRepository
    {
        private readonly ApplicationDbContext dbContext;

        public CarteRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<Carte> CreateAsync(Carte carte)
        {
            await dbContext.Carti.AddAsync(carte);
            await dbContext.SaveChangesAsync();
            return carte;
        }

        public async Task<IEnumerable<Carte>> GetAllAsync()
        {
            return await dbContext.Carti.ToListAsync();
        }

        public async Task<Carte?> GetCarteById(Guid id)
        {
            return await dbContext.Carti.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
