
namespace rugby_stat_tracker.Models
{
    public class IndividualStats
    {

        public Player PlayerId { get; set; }
        public Match MatchId { get; set; }
        // Do I need this?
        public Team TeamId { get; set; }
        public int Position { get; set; }
        public int Minutes { get; set; }
        public int Tries { get; set; }
        public int ConversionAttempts { get; set; }
        public int ConverstionMakes { get; set; }
        public int DropGoals { get; set; }

    }

}

