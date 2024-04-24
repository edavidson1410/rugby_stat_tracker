namespace rugby_stat_tracker.Models
{
    public class Player
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public string? Birthdate { get; set; }
        public string? Position { get; set; }
        public string? Hometown { get; set; }
        public Team TeamId { get; set; }
        public ICollection<IndividualStats> IndividualStats { get; set; }

    }
}
