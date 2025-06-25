using Microsoft.EntityFrameworkCore;
using ASPCoreWebAPI.Models;

namespace ASPCoreWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
