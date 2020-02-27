using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RiseFood.Core.Data;
using RiseFood.Gestor.Data.Mappings;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Data
{
    public class GestorDbContext : DbContext, IUnitOfWork
    {
        public GestorDbContext(DbContextOptions<GestorDbContext> options) : base(options) {}
        
        public DbSet<Supplie> Supplies { get; set; }
        public DbSet<SupplieCategory> SupplieCategories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GestorDbContext).Assembly);

        }

        public async  Task<bool> Commit()
        {
            return await base.SaveChangesAsync() > 0;
        }
    }
}
