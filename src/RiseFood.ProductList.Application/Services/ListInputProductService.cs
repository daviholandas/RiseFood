using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application.Services
{
    public class ListInputProductService : IListInputProductService
    {
        private readonly ISuppliesServiceFacade _suppliesServiceFacade;
        
        public ListInputProductService(ISuppliesServiceFacade suppliesServiceFacade)
        {
            _suppliesServiceFacade = suppliesServiceFacade;
        }
        
        public async Task<IEnumerable<InputProductDto>> ListInputProducts()
        {
            return await _suppliesServiceFacade.ListInputProducts();
        }

        public async Task<IEnumerable<InputProductDto>> ListInputProductsBySupplyCategory(string suppliesCategory)
        {
            return await _suppliesServiceFacade.ListInputProductsByCategory(suppliesCategory);
        }
        
        
        public async Task<IEnumerable<object>> ListInputProductCategories()
        {
            return await _suppliesServiceFacade.ListInputProductsCategories();
        }
    }
}