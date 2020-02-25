using System;
using Microsoft.EntityFrameworkCore;
using RiseFood.Gestor.Data.Mappings;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Data
{
    public class GestorDbContext : DbContext
    {
        public GestorDbContext(DbContextOptions<GestorDbContext> options) : base(options) {}
        
        public DbSet<Supplie> Supplies {get;}
        public DbSet<SupplieCategory> SupplieCategories {get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GestorDbContext).Assembly);
        }
    }
}
