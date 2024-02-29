using ASP.NET8_CRUD_DEMO.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET8_CRUD_DEMO.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
