using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.Core.Data;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Data.Repositories
{
    public class SupplieRepository : ISupplieRepository
    {
        public IUnitOfWork UnitOfWork => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SupplieCategory>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplie>> GetAllSupplies()
        {
            throw new NotImplementedException();
        }

        public Task<Supplie> GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Task<Supplie> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Supplie>> GetSuppliesByCategory(string categoryCode)
        {
            throw new NotImplementedException();
        }
    }
}
