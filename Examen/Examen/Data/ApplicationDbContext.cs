using Examen.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Examen.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Autor> Autori {  get; set; }
        public DbSet<Carte> Carti { get; set; }
        public DbSet<Editura> Edituri { get; set; }
    }
}
