using Microsoft.EntityFrameworkCore;

namespace RiseFood.App.WebApi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        
    }
}