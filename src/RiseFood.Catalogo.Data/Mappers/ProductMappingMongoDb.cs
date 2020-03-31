using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using RiseFood.Catalogo.Domain;
using RiseFood.Catalogo.Domain.Enums;

namespace RiseFood.Catalogo.Data.Mappers
{
    public static class ProductMappingMongoDb
    {
        public static void Mapper()
        {
            BsonClassMap.RegisterClassMap<Product>(map =>
            {
                map.AutoMap();
                map.MapMember(p => p.Code).SetIsRequired(true);
                map.MapMember(p => p.Name).SetIsRequired(true);
                map.MapMember(p => p.Price).SetSerializer(new DecimalSerializer(BsonType.Decimal128));
                map.MapMember(p => p.Size).SetSerializer(new EnumSerializer<Sizes>(BsonType.String));

            });
        }
    }
}