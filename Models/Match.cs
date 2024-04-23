namespace rugby_stat_tracker.Models
{
    public class Match
    {

        public int Id { get; set; }

        public required Team HomeTeam { get; set; }

        public required Team AwayTeam{ get; set; }

        public required int HomeScore { get; set; }

        public required int AwayScore { get; set; }

        public string? Location { get; set; }

        public DateOnly Date { get; set; }
    }
}
