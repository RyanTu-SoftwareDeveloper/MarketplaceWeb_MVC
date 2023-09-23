using Microsoft.EntityFrameworkCore;

namespace MarketplaceWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }

    }
}
