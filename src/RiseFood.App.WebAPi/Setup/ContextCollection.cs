using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.Gestor.Data;


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
