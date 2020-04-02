using System;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.App.WebAPi;
using RiseFood.Catalogo.Application.AutoMapper;
using RiseFood.Catalogo.Application.Commands;
using RiseFood.Catalogo.Data;
using RiseFood.Catalogo.Data.Repositories;
using RiseFood.Catalogo.Domain;
using RiseFood.Core.Communication.Mediator;
using RiseFood.Core.Messages.CommonMessages.Notifications;
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
            //Mediator
            services.AddMediatR(typeof(Startup));
            services.AddScoped<IMediatorHandler, MediatorHandler>();

            //Notification
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            
            //AutoMapper
            services.AddAutoMapper(
                typeof(DomianToDtoAutomapperProfile), 
                typeof(DtoToDomainAutoMapperProfile),
                typeof(DomainToCommandAutoMapperProfile),
                typeof(CommandToEntityAutoMapperProfile)
            );

            //Gestor Domain
            services.AddScoped<ISupplieRepository, SupplieRepository>();
            services.AddScoped<ISupplieAppService, SupplieAppService>();
            services.AddScoped<GestorDbContext>();
            
            //Catalogo Domain
            services.AddScoped<MongoContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IRequestHandler<CreateProductCommand, bool>, ProductCommandHandler>();
            services.AddScoped<IRequestHandler<CreateCategoryCommand, bool>, ProductCommandHandler>();
            
            return services;
        }
    }
}
