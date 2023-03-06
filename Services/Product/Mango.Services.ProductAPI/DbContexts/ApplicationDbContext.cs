using Mango.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Mango.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Product> Products { get; set; }
        protected override void  OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductId= 1,
                Name = "Samosa",
                Price = 15,
                Description= "hfwefh kjgjern kdfwolan lingrlk",
                ImageUrl = "",
                CategoryName = "Appetizer"
            });
        }
    }
}
