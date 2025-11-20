using Microsoft.EntityFrameworkCore;

namespace PricingService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=pricing.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Candidates can add their entity configurations here
        }

        // Candidates should add their DbSet properties here
    }
}