using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using RiseFood.App.WebApi.Data;
using RiseFood.App.WebAPi.Models;

namespace RiseFood.App.WebApi.Setup
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddIdentityConfiguration(this IServiceCollection services)
        {
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
            return services;
        }
    }
}