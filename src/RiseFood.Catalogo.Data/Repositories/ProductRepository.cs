using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using RiseFood.Catalogo.Domain;
using RiseFood.Core.Data;

namespace RiseFood.Catalogo.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly MongoContext _context;
        private IMongoCollection<Product> _products;
        private IMongoCollection<Category> _categories;
        

        public ProductRepository(MongoContext context)
        {
            _context = context;
            ConfigureCollections();
        }

        private void ConfigureCollections()
        {
              _products = _context.GetCollection<Product>("products");
              _categories = _context.GetCollection<Category>("categories");
             
        }
        
        public IUnitOfWork UnitOfWork => _context;
        
        
        public void SaveProduct(Product product)
        {
            _context.AddCommand(() => _products.InsertOneAsync(product));
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(int productCode)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProduct(string productName)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            return await _products.Find(p => true).ToListAsync();
        }

        public void SaveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(Guid categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(int categoryCode)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetProductsByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}