using BookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BookWeb.Data
{
	public class ApplicationDbContext : DbContext
	{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) 
        {
                
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, ProductName = "Mojo", ProductCategory = "SoftDrink" },
                new Product { Id = 2, ProductName = "Alooz", ProductCategory = "Chips" },
                new Product { Id = 3, ProductName = "Frooteka", ProductCategory = "Juice" }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Action",DispalyOrder=1},
                new Category { Id=2,Name="Scifi",DispalyOrder=2},
                new Category { Id=3,Name="Comedy",DispalyOrder=3 }
                );
        }
    }
}
