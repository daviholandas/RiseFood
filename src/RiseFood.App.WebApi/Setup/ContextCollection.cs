using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.App.WebApi.Data;
using RiseFood.Gestor.Data;


namespace RiseFood.App.WebApi.Setup
{
    public static class ContextCollection
    {
        public static IServiceCollection ContextCollectionResolve(this IServiceCollection services, IConfiguration configuration)
        {
            //Gestor Context
            services.AddDbContext<GestorDbContext>(options => options.UseMySql(configuration.GetConnectionString("GestorDbConnection")));
            
            //Application Context
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(configuration.GetConnectionString("DefaultConnection")));
            
            return services;
        }
    }
}
