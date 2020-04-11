using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace RiseFood.ProductList.AntiCorruption
{
    public class SuppliesService : ISuppliesService
    {
        private readonly IMongoCollection<Insumos> _insumos;

        public SuppliesService(string connectionString, string database)
        {
            var client = new MongoClient(connectionString).GetDatabase(database);
            _insumos = client.GetCollection<Insumos>("supplies");
        }
        
        public async Task<IEnumerable<Insumos>> GetAllInsumos()
        {
            var insumos = await _insumos.FindSync(i => true).ToListAsync();
            return insumos;
        }

        public async Task<IEnumerable<Insumos>> GetAllInsumosByCategory(string categoryName)
        {
            var filter = new BsonDocument("Category", new Regex(categoryName, RegexOptions.IgnoreCase));
            var insumos = await _insumos.FindSync(filter).ToListAsync();
            return insumos;
        }

        public async Task<IEnumerable<object>> ListCategories()
        {
            return await _insumos.Aggregate()
                .Group(i => i.Category, g => new {Category = g.Key})
                .ToListAsync();
        }
    }
}