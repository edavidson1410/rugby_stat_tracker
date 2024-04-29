using rugby_stat_tracker.Models;

namespace rugby_stat_tracker
{
    
    public class PlayerDataStore
    {
        public List<Player> Players { get; set; }

        public static PlayerDataStore Current { get; } = new PlayerDataStore();

        public PlayerDataStore()
        {
            Players = new List<Player>()
            {
                new Player()
                {
                    Id = 1,
                    Name = "Eric Davidson",
                    Hometown = "Jackson, MO",
                    Birthdate = DateTime.Parse("1992-07-26"),
                    Position = 13,
                    IndividualGames = new List<IndividualGame>()
                    {
                        new IndividualGame()
                        {
                            Id=1,
                            Position=13,
                            Minutes=80,
                            Tries=1
                        }
                    }
                },
                new Player()
                {
                    Id = 2,
                    Name = "Aidan Milne",
                    Hometown = "Nelson, New Zealand",
                    Birthdate = DateTime.Parse("1992-07-26"),
                    Position = 12,
                    IndividualGames = new List<IndividualGame>()
                    {
                        new IndividualGame()
                        {
                            Id=2,
                            Position=13,
                            Minutes=80,
                            Tries=2
                        }
                    }
                },
                new Player()
                {
                    Id = 3,
                    Name = "Victor Romero",
                    Hometown = "Mexico",
                    Birthdate = DateTime.Parse("1992-07-26"),
                    Position = 6,
                    IndividualGames = new List<IndividualGame>()
                    {
                        new IndividualGame()
                        {
                            Id=3,
                            Position=13,
                            Minutes=80,
                            Tries=3
                        }
                    }
                }
            };
        }

    }
}
