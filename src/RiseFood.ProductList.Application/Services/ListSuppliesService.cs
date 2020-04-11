using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application.Services
{
    public class ListSuppliesService : IListSuppliesService
    {
        private readonly ISuppliesServiceFacade _suppliesServiceFacade;
        
        public ListSuppliesService(ISuppliesServiceFacade suppliesServiceFacade)
        {
            _suppliesServiceFacade = suppliesServiceFacade;
        }
        
        public async Task<IEnumerable<Supply>> ListSupplies()
        {
            return await _suppliesServiceFacade.ListSupplies();
        }

        public async Task<IEnumerable<Supply>> ListSuppliesByInsumoCategory(string categoryInsumo)
        {
            return await _suppliesServiceFacade.ListSuppliesByCategory(categoryInsumo);
        }

        public async Task<IEnumerable<object>> ListInsumosCategories()
        {
            return await _suppliesServiceFacade.ListSuppliesCategories();
        }
    }
}