using MongoDB.Bson.Serialization;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Data.Mappers
{
    public static class CategoryMapping
    {
        public static void Mapper()
        {
            BsonClassMap.RegisterClassMap<Category>(map =>
            {
                map.AutoMap();
                map.MapMember(c => c.Name).SetIsRequired(true);
            });
        }
    }
}