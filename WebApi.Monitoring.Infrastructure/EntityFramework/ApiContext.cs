using Microsoft.EntityFrameworkCore;
using WebApi.Monitoring.Domain.Entities;

namespace WebApi.Monitoring.Infrastructure.EntityFramework
{
    public class ApiContext : DbContext
    {
        protected ApiContext()
            : base()
        {
        }

        protected ApiContext(DbContextOptions<ApiContext> options)
                : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<ApiConfiguration> APIConfiguration { get; set; }
    }
}
