using Microsoft.EntityFrameworkCore;

namespace HC_WEB_FINALPROJECT.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Account {get;set;}
        public AppDbContext (DbContextOptions options):base(options)
        {
            
        }
    }
}