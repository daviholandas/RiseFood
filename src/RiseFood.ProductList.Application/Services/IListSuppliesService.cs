using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application.Services
{
    public interface IListSuppliesService
    {
        Task<IEnumerable<Supply>> ListSupplies();
        Task<IEnumerable<Supply>> ListSuppliesByInsumoCategory(string categoryInsumo);
        Task<IEnumerable<object>> ListInsumosCategories();
    }
}