using ElectroMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectroMVC.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
          
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slides> Slides { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tags> Tags { get; set; }
        public DbSet<BestSellerProducts> BestSellerProducts { get; set; }
        public DbSet<BestSellerProductToTag> BestSellerProductToTags { get; set; }


    }
}
