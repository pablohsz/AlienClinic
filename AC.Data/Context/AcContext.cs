using AC.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AC.Data.Context
{
    public class AcContext : DbContext
    {

        public AcContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
