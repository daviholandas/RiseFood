using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using RiseFood.Core.Data;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Data.Repositories
{
    public class ProductListRepository : IProductListRepository
    {
        private readonly ProductListContextMongo _context;
        private readonly IMongoCollection<Product> _products;
        private readonly IMongoCollection<Category> _categories;
        
        public ProductListRepository(ProductListContextMongo context)
        {
            _context = context;
            _products = _context.GetCollection<Product>("products");
            _categories = _context.GetCollection<Category>("categories");
        }
        
        public IUnitOfWork UnitOfWork => _context;
        
        public void SaveProduct(Product product)
        {
            _context.AddCommand(() => _products.InsertOneAsync(product));
        }

        public async Task SaveManyProduct(IEnumerable<Product> products)
        {
           _context.AddCommand(() => _products.InsertManyAsync(products));
           await Task.CompletedTask;
        }

        public void UpdateProduct(Product product)
        {
            var filter = new BsonDocument("_id", product.Id);
            _context.AddCommand(() => _products.ReplaceOneAsync(filter, product));
        }

        public void DeleteProduct(Guid productId)
        {
            var filter = new BsonDocument("_id", productId);
            _context.AddCommand(() => _products.DeleteOneAsync(filter));
        }

        public async Task<Product> GetProduct(int productCode)
        {
            var filter = new BsonDocument("Code", productCode);
            var product =  await _products.FindAsync(filter);
            return await product.SingleOrDefaultAsync();
        }

        public async Task<Product> GetProduct(string productName)
        {
            var filter = new BsonDocument("Name", productName);
            var product =  await _products.FindAsync(filter);
            return await product.SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetAllProduct()
        {
            var products= await _products.FindAsync(p => true);
            return await products.ToListAsync();
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
            _context?.Dispose();
        }

        
    }
}