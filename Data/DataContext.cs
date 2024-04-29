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
        public DbSet<IndividualGame> IndividualGames { get; set; }

        // Connection to Db
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }


        //TODO: might need to join relationships
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .HasData(
                    new Player()
                    {
                        Id = 1,
                        Name = "Eric Davidson",
                        Hometown = "Jackson, MO",
                        Birthdate = DateTime.Parse("1992-07-26"),
                        Position = 13
                    },
                    new Player()
                    {
                        Id = 2,
                        Name = "Aidan Milne",
                        Hometown = "Nelson, New Zealand",
                        Birthdate = DateTime.Parse("1992-07-26"),
                        Position = 12
                    },
                    new Player()
                    {
                        Id = 3,
                        Name = "Victor Romero",
                        Hometown = "Mexico",
                        Birthdate = DateTime.Parse("1992-07-26"),
                        Position = 6
                    }
                );

            modelBuilder.Entity<IndividualGame>()
                .HasData(
                    new IndividualGame()
                    {
                        Id = 1,
                        Position = 13,
                        Minutes = 80,
                        Tries = 1
                    },
                    new IndividualGame()
                    {
                        Id = 2,
                        Position = 13,
                        Minutes = 80,
                        Tries = 1
                    },
                    new IndividualGame()
                    {
                        Id = 3,
                        Position = 13,
                        Minutes = 80,
                        Tries = 1
                    }
                );

           
            base.OnModelCreating(modelBuilder);
        }

    }
}
