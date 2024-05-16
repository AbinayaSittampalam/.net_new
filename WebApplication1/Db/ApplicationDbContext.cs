using Microsoft.EntityFrameworkCore;
using WebApplication1.model;

namespace WebApplication1.Db
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options) 
        {
            
        }
        public DbSet<student> Students{ get; set; }
    }
}
