using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.Core.Data;

namespace RiseFood.ProductList.Domain
{
    public interface IProductListRepository : IRepository<Product>
    {
        void SaveProduct(Product product);
        Task SaveManyProduct(IEnumerable<Product> products);
        void UpdateProduct(Product product);
        void DeleteProduct(Guid productId);
        Task<Product> GetProduct(int productCode);
        Task<Product> GetProduct(string productName);
        Task<IEnumerable<Product>> GetAllProduct();

        void SaveCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Guid categoryId);
        Task<IEnumerable<Category>> GetAllCategories();
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryCode);
        Task<IEnumerable<Product>> GetProductsByCategory(string categoryName);
    }
}