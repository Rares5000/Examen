using Examen.Data;
using Examen.Models.Domain;
using Examen.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.Implementation
{
    public class AutorRepository : IAutorRepository
    {
        private readonly ApplicationDbContext dbContext;

        public AutorRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }   
        public async Task<Autor> CreateAsync(Autor autor)
        {
            await dbContext.Autori.AddAsync(autor);
            await dbContext.SaveChangesAsync();
            return autor;
        }

        public async Task<IEnumerable<Autor>> GetAllAsync()
        {
            return await dbContext.Autori.Include(x => x.Carti).ToListAsync();
        }

        public async Task<Autor?> GetAutorById(Guid id)
        {
            return await dbContext.Autori.Include(x => x.Carti).FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
