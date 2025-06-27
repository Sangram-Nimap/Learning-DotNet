using Microsoft.EntityFrameworkCore;
using WebApiCrud.Model;
namespace WebApiCrud.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set;} 
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        

        
    }
}
