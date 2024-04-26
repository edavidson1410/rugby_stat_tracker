using Microsoft.AspNetCore.Mvc;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Controllers
{
    //generic api endpoint name, could use [controller] but would like endpoint to stay same even during refactoring.
    [Route("api/players")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        //GET all players
        [HttpGet]
        public ActionResult<IEnumerable<Player>> GetPlayers()
        {
            return Ok(PlayerDataStore.Current.Players);
        }
        
        [HttpGet("{id}")]
        public ActionResult<Player> GetPlayer(int id)
        {

            var playerResult = PlayerDataStore.Current.Players
                .FirstOrDefault(p => p.Id == id);

            if (playerResult == null)
            {
                return NotFound();
            }

            return Ok(playerResult);
        }

    }
}
