namespace rugby_stat_tracker.Models
{
    public class Player
    {
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public int? Position { get; set; }
        public string? Hometown { get; set; }
        //public Team TeamId { get; set; }
        public int NumberOfGames
        {
            get
            {
                return IndividualGames.Count;
            }
        }
        //Instantiating a empty collection will avoid null issues
        public ICollection<IndividualGames> IndividualGames { get; set; }
            = new List<IndividualGames>();

    }
}
