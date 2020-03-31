using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using RiseFood.Core.Data;

namespace RiseFood.Catalogo.Domain
{
    public interface IProductRepository : IRepository<Product>
    {
        void SaveProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Guid productId);
        Task<Product> GetProduct(Guid productId);
        Task<Product> GetProduct(int productCode);
        Task<Product> GetProduct(string productName);
        Task<IEnumerable<Product>> GetAllProduct();

        void SaveCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Guid categoryId);
        Task<IEnumerable<Category>> GetAllCategories();
        Task<IEnumerable<Product>> GetProductsByCategory(Guid categoryId);
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryCode);
        Task<IEnumerable<Product>> GetProductsByCategory(string categoryName);
        
    }
}