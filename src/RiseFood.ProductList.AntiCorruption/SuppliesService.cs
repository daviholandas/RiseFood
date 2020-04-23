using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace RiseFood.ProductList.AntiCorruption
{
    public class SuppliesService : ISuppliesService
    {
        private readonly IMongoCollection<Supply> _supplies;

        public SuppliesService(string connectionString, string database)
        {
            var client = new MongoClient(connectionString).GetDatabase(database);
            _supplies = client.GetCollection<Supply>("supplies");
        }
        
        public async Task<IEnumerable<Supply>> GetAllSupplies()
        {
            var supplies = await _supplies.FindSync(i => true).ToListAsync();
            return supplies;
        }

        public async Task<IEnumerable<Supply>> GetAllSuppliesByCategory(string categoryName)
        {
            var filter = new BsonDocument("Category", new Regex(categoryName, RegexOptions.IgnoreCase));
            var supplies = await _supplies.FindSync(filter).ToListAsync();
            return supplies;
        }

        public async Task<IEnumerable<object>> ListCategories()
        {
            return await _supplies.Aggregate()
                .Group(i => i.Category, g => new {Category = g.Key})
                .ToListAsync();
        }
    }
}