using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("rugby_stat_tracker"));
        }

        public DbSet<Player> Players { get; set; }
    }
}
