using Microsoft.Extensions.DependencyInjection;
using RiseFood.Catalogo.Data.Mappers;

namespace RiseFood.App.WebApi.Setup
{
    public static class MappersMongoDb
    {
        public static IServiceCollection AddMongoMappers(this IServiceCollection services)
        {
            ProductMappingMongoDb.Mapper();
            CategoryMappingMongoDb.Mapper();
            return  services;
        }
    }
}