using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.Gestor.Data;
using Microsoft.EntityFrameworkCore;

namespace RiseFood.App.WebAPi.Setup
{
    public static class ContextCollection
    {
        public static IServiceCollection ContextCollectionResolve(this IServiceCollection services, IConfiguration configuration)
        {
            //Gestor Context
            services.AddDbContext<GestorDbContext>(options => options.UseMySql(configuration.GetConnectionString("GestorDbConnection")));

            return services;
        }
    }
}
