using A01.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace A01.Data
{
    public class AzureDbContext : DbContext
    {
        public AzureDbContext(DbContextOptions<AzureDbContext> options)
           : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        //public DbSet<Authorization> Authorizations { get; set; }// throwing because primary key must be set
    }
}
