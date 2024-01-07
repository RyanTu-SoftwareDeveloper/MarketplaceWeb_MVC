using MarketplaceWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace MarketplaceWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
        }
        public DbSet<Category> Categories { get; set; }

        //using ModelBuilder we can see data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Python book", DisplayOrder = 1},
                new Category { Id = 2, Name = "Java book", DisplayOrder = 2 },
                new Category { Id = 3, Name = "c# book", DisplayOrder = 3 }

                );
        }

    }
}
