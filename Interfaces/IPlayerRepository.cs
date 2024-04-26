using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Interfaces
{
    public interface IPlayerRepository
    {
        ICollection<Player> GetAllPlayers();
        Player GetPlayerById(int id);
        Player GetPlayerByName(string name);
        bool CreatePlayer(int id, DateTime Birthdate, string Position, string Hometown);
        bool UpdatePlayer(int id, DateTime Birthdate, string Position, string Hometown;
        bool DeletePlayer(Player player);
        bool Save();

    }
}
