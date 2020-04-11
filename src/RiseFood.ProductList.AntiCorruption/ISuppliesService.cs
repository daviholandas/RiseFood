using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace RiseFood.ProductList.AntiCorruption
{
    public interface ISuppliesService
    {
        Task<IEnumerable<Insumos>> GetAllInsumos();
        Task<IEnumerable<Insumos>> GetAllInsumosByCategory(string categoryName);
        Task<IEnumerable<object>> ListCategories();
    }
}