using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.Core.Data;

namespace RiseFood.Gestor.Domain
{
    public interface ISupplieRepository : IRepository<Supplie>
    {
        Task<IEnumerable<Supplie>> GetAllSupplies();
        Task<Supplie> GetById(int id);
        Task<Supplie> GetByCode(string code);

        Task<IEnumerable<SupplieCategory>> GetAllCategories();
        Task<IEnumerable<Supplie>> GetSuppliesByCategory(string categoryCode);
    }
}
