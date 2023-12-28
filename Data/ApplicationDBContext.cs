using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options) 
        { 
        }
        public DbSet<Task> Tasks { get; set; }
    }
}
