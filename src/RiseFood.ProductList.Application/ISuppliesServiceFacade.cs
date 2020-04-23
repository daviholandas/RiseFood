using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application
{
    public interface ISuppliesServiceFacade
    {
        Task<IEnumerable<InputProductDto>> ListInputProducts();
        Task<IEnumerable<InputProductDto>> ListInputProductsByCategory(string categoryName);
        Task<IEnumerable<object>> ListInputProductsCategories();
    }
}