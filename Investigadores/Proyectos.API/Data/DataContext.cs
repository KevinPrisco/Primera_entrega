using Microsoft.EntityFrameworkCore;
using Proyectos.Shared.Entities;

namespace Proyectos.API.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Proyectos> proyectos { get; set; }
    }
}
