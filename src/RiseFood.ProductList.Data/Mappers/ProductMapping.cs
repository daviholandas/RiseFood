using MongoDB.Bson.Serialization;
using RiseFood.ProductList.Domain;

namespace RiseFood.ProductList.Data.Mappers
{
    public static class ProductMapping
    {
        public static void Mapper()
        {
            BsonClassMap.RegisterClassMap<Product>(map =>
            {
                map.AutoMap();
                map.MapMember(p => p.Name).SetIsRequired(true);
                map.MapMember(p => p.Code).SetIsRequired(true);
                map.MapCreator(p=> new Product(p.Code, p.Name, p.Price, p.Description, p.Size, p.Category, p.AdditionalProducts));
            });
        }
    }
}