using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace sample_azure.Data
{
    public class AzureContext : DbContext
    {
        public AzureContext(DbContextOptions<AzureContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("SalesLT");
        }
    }
}