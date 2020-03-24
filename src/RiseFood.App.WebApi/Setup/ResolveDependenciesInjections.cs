using System;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.Gestor.Application.AutoMapper;
using RiseFood.Gestor.Application.Services;
using RiseFood.Gestor.Data;
using RiseFood.Gestor.Data.Repositories;
using RiseFood.Gestor.Domain;

namespace RiseFood.App.WebApi.Setup
{
    public static class ResolveDependenciesInjections
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //Gestor Domain
            services.AddScoped<ISupplieRepository, SupplieRepository>();
            services.AddScoped<ISupplieAppService, SupplieAppService>();
            services.AddScoped<GestorDbContext>();
            services.AddAutoMapper(typeof(DomianToDtoAutomapperProfile), typeof(DtoToDomainAutoMapperProfile));

            return services;
        }
    }
}
