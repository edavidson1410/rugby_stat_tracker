using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rugby_stat_tracker.Models
{
    public class Player
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; } = string.Empty;
        public DateTime Birthdate { get; set; }
        public int? Position { get; set; }
        public string? Hometown { get; set; }
        //[ForeignKey("TeamId")
        //public Team? TeamId { get; set; }
        public int NumberOfGames
        {
            get
            {
                return IndividualGames.Count;
            }
        }
        //Instantiating a empty collection will avoid null issues
        public ICollection<IndividualGame> IndividualGames { get; set; }
            = new List<IndividualGame>();

    }
}
