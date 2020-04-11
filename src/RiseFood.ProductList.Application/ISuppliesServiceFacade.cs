using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application
{
    public interface ISuppliesServiceFacade
    {
        Task<IEnumerable<Supply>> ListSupplies();
        Task<IEnumerable<Supply>> ListSuppliesByCategory(string categoryName);
        Task<IEnumerable<object>> ListSuppliesCategories();
    }
}