using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Data
{
    public class AppDbContext : DbContext
    {
        // Connection to Db
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // Sets tables in Db (convetion is plural)
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Match> Matches { get; set; }

        // Customizes tables without going into Db
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many to Many relationships
            modelBuilder.Entity<Team>()
                 .HasKey(p => new { p.Matches });
            modelBuilder.Entity<Team>()
                .HasMany(p => p.Matches);
        }
    }
}
