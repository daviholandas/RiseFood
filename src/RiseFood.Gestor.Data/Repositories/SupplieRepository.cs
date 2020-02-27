using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RiseFood.Core.Data;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Data.Repositories
{
    public class SupplieRepository : ISupplieRepository
    {
        private readonly GestorDbContext _gestorDbContext;

        public SupplieRepository(GestorDbContext gestorDbContext)
        {
            _gestorDbContext = gestorDbContext;
        }
        
        public IUnitOfWork UnitOfWork => _gestorDbContext;


        public async Task<IEnumerable<SupplieCategory>> GetAllCategories()
        {
            return await _gestorDbContext.SupplieCategories.AsNoTracking().ToListAsync();
        }

        public async Task<IEnumerable<Supplie>> GetAllSupplies()
        {
            return await _gestorDbContext.Supplies.AsNoTracking().Include(s => s.SupplieCategory).ToListAsync();
        }

        public async Task<Supplie> GetSupplieByCode(string code)
        {
            return await _gestorDbContext.Supplies.AsNoTracking().FirstOrDefaultAsync(s => s.Code == code);
        }

        public async Task<Supplie> GetSupplieById(int id)
        {
            return await _gestorDbContext.Supplies.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<Supplie>> GetSuppliesByCategory(string categoryCode)
        {
            return await _gestorDbContext.Supplies.AsNoTracking()
                .Include(s => s.SupplieCategory).Where(s => s.SupplieCategoryCode == categoryCode).ToListAsync();
        }

        public void Dispose()
        {
            _gestorDbContext?.Dispose();
        }
    }
}
