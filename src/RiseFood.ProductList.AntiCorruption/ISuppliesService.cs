using System.Collections.Generic;
using System.Threading.Tasks;

namespace RiseFood.ProductList.AntiCorruption
{
    public interface ISuppliesService
    {
        Task<IEnumerable<Supply>> GetAllSupplies();
        Task<IEnumerable<Supply>> GetAllSuppliesByCategory(string categoryName);
        Task<IEnumerable<object>> ListCategories();
    }
}