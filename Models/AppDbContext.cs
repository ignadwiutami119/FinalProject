using Microsoft.EntityFrameworkCore;

namespace HC_WEB_FINALPROJECT.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Account> Account {get;set;}
        public DbSet<Employee> Employee {get;set;}
        public DbSet<Paging> Pagings {get;set;}
        public AppDbContext (DbContextOptions options):base(options)
        {
            
        }
    }
}