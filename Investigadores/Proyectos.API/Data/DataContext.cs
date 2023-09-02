using Proyectos.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Proyectos.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Proyectos>Proyectos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Proyectos>().HasIndex(c => c.Id).IsUnique();
        }

    }
        
}
