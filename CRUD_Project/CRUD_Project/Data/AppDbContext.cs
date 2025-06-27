using CRUD_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Project.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
          public DbSet<User> User { get; set; }
         public DbSet<Product> Products { get; set; }
         public DbSet<Category> Categories { get; set; }
         public DbSet<Order> Order { get; set; }

         
        

    }
}
