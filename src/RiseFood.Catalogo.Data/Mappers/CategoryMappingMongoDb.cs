using MongoDB.Bson.Serialization;
using RiseFood.Catalogo.Domain;

namespace RiseFood.Catalogo.Data.Mappers
{
    public static class CategoryMappingMongoDb
    {
        public static void Mapper()
        {
            BsonClassMap.RegisterClassMap<Category>(map =>
            {
                map.MapMember(c => c.Code).SetIsRequired(true);
                map.MapMember(c => c.Name).SetIsRequired(true);
            });
        }
    }
}