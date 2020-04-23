using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Application.Services
{
    public interface IListInputProductService
    {
        Task<IEnumerable<InputProductDto>> ListInputProducts();
        Task<IEnumerable<InputProductDto>> ListInputProductsBySupplyCategory(string suppliesCategory);
        Task<IEnumerable<object>> ListInputProductCategories();
    }
}