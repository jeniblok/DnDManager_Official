using Microsoft.EntityFrameworkCore;

namespace DnDManager.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // DbSet properties go here

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data goes here
        }
    }
}