using Microsoft.AspNetCore.Mvc;
using rugby_stat_tracker.Data;
using rugby_stat_tracker.Interfaces;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
       private readonly DataContext _appDbContext;

        public PlayerRepository(DataContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public List<Player> GetAllPlayers(int id)
        {
            return _appDbContext.Players.OrderBy(p => p.Id).ToList();
        }

        public Player GetPlayerById(int id)
        {
            return _appDbContext.Players.FirstOrDefault(p => p.Id == id);
        }

        public Player GetPlayerByName(string name) 
        {
            return _appDbContext.Players.FirstOrDefault(p => p.Name == name);
        }

        [HttpPost]
        public bool CreatePlayer(int id, DateTime Birthdate, string Position, string Hometown)
        {

        }
    }
}
 