using Microsoft.Extensions.DependencyInjection;
using RiseFood.ProductList.Data.Mappers;

namespace RiseFood.IoC
{
    public static class EntitiesMappersResolve
    {
        public static IServiceCollection AddMongoMappers(this IServiceCollection services)
        {
            ProductMapping.Mapper();
            CategoryMapping.Mapper();
            return  services;
        }
    }
}