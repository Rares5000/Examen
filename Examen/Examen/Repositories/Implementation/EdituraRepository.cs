using Examen.Data;
using Examen.Models.Domain;
using Examen.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Examen.Repositories.Implementation
{
    public class EdituraRepository : IEdituraRepository
    {
        private readonly ApplicationDbContext dbContext;

        public EdituraRepository(ApplicationDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public async Task<Editura> CreateAsync(Editura editura)
        {
            await dbContext.Edituri.AddAsync(editura);
            await dbContext.SaveChangesAsync();
            return editura;
        }

        public async Task<IEnumerable<Editura>> GetAllAsync()
        {
            return await dbContext.Edituri.ToListAsync();
        }
    }
}
