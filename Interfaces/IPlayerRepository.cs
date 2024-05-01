using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Interfaces
{
    public interface IPlayerRepository
    {
        Task<IEnumerable<Player>> GetAllPlayersAsync();
        Task<Player?> GetByPlayerIdAsync(int id, bool includeIndividualGames);
        Task<Player?> GetByPlayerNameAsync(string name, bool includeIndividualGames);
        //Task<IEnumerable<IndividualGame>> GetAllIndividualGamesAsync(int playerId);
        //Task<IndividualGame> GetByIndividualGameIdAsync(int id);
        //bool CreatePlayer(Player player);
        //bool UpdatePlayer(Player player);
        //bool DeletePlayer(Player player);
        //bool Save();

    }
}
