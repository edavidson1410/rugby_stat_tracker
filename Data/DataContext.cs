using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Data
{
    public class DataContext : DbContext
    {
        // Sets tables in Db (convetion is plural)
        public DbSet<Player> Players { get; set; }
        //public DbSet<Team> Teams { get; set; }
        //public DbSet<Match> Matches { get; set; }
        public DbSet<IndividualGames> IndividualStats { get; set; }

        // Connection to Db
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        //TODO: might need to join relationships
/*        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }*/

    }
}
