using BlogPostApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogPostApp.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContext): base(dbContext)
        {
            
        }

        public DbSet<User> Users { get; set; }
        
    }
}
