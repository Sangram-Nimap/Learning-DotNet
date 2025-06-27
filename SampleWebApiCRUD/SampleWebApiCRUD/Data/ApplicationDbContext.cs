using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SampleWebApiCRUD.Model;

namespace SampleWebApiCRUD.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        
            public DbSet<Student> Students { get; set; }
        
    }
}
