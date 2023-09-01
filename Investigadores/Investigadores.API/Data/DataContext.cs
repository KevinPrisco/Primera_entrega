using Investigadores.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Investigadores.API.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


            public DbSet<Cientifico> Cientificos { get; set; }

            public DbSet<Colaborador> Colaboradores { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cientifico>().HasIndex(c => c.Nombre).IsUnique();

        }

    }

}