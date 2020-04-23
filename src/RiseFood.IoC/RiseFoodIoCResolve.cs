using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.ProductList.AntiCorruption;
using RiseFood.ProductList.AntiCorruption.AutoMapper;
using RiseFood.ProductList.Application;
using RiseFood.ProductList.Application.Services;
using RiseFood.ProductList.Data;
using RiseFood.ProductList.Data.Repositories;
using RiseFood.ProductList.Domain;

namespace RiseFood.IoC
{
    public static class RiseFoodIoCResolve
    {
        public static IServiceCollection ResolveDependenciesInjection(this IServiceCollection services, IConfiguration configuration)
        {
            //Mapping Entities
            services.AddMongoMappers();
            
            //AutoMapper
            services.AddAutoMapper(
                typeof(SupplyToInputProductAutoMapperProfile)
            );
            
            //ListProducts
            services.AddScoped<ISuppliesServiceFacade, SuppliesServiceFacade>();
            services.AddScoped<IListInputProductService, ListInputProductService>();
            services.AddSingleton<ProductListContextMongo>();
            services.AddScoped<IProductListRepository, ProductListRepository>();
            
            
            
            //Service Anti Corruption Layer
            services.AddSingleton<ISuppliesService>(
                new SuppliesService(configuration.GetSection("Databases")["RemoteDatabase:ConnectionString"], 
                    configuration.GetSection("Databases")["RemoteDatabase:DatabaseName"]));
            
            
            
            return services;
        }
    }
}