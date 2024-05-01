using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            _appDbContext = appDbContext ?? throw new ArgumentNullException(nameof(appDbContext));
        }

        [HttpGet]
        public async Task<IEnumerable<Player>> GetAllPlayersAsync()
        {
            return await _appDbContext.Players.OrderBy(p => p.Name).ToListAsync();
        }

        public async Task<Player?> GetByPlayerIdAsync(int id, bool includeIndividualGames)
        {
            if (includeIndividualGames)
            {
                return await _appDbContext.Players.Include(p => p.IndividualGames)
                    .FirstOrDefaultAsync(p => p.Id == id);
            }
            return await _appDbContext.Players.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Player?> GetByPlayerNameAsync(string name, bool includeIndividualGames) 
        {
            if (includeIndividualGames)
            {
                return await _appDbContext.Players.Include(p => p.IndividualGames)
                    .FirstOrDefaultAsync(p => p.Name == name);
            }
            return await _appDbContext.Players.FirstOrDefaultAsync(p => p.Name == name);
        }
    }
}
 