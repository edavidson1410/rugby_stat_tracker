namespace rugby_stat_tracker.Models
{
    public class Team
    {
        public required int Id { get; set; }

        public required string Name { get; set; }

        public string? Location { get; set; }

        public string? Founded {  get; set; }

        public ICollection<Match> Matches { get; set; }

        public ICollection<IndividualStats> IndividualStats { get; set; }
    }
}
