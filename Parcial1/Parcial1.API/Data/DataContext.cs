using Microsoft.EntityFrameworkCore;
using Parcial1.Shared.Entities;

namespace Parcial1.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { 

        }
        
        public DbSet<Registro> Registros { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Registro>().HasIndex(x => x.IdBoleta).IsUnique();
        }

    }
}
