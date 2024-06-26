﻿using Microsoft.AspNetCore.Mvc;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Controllers
{
    //Child resource
    [Route("api/players/{playerId}/individualgames")]
    [Produces("application/json")]
    [ApiController]
    public class IndividualGameController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<IndividualGame>> GetIndividualStats(int playerId)
        {
            var player = PlayerDataStore.Current.Players.FirstOrDefault(p => p.Id == playerId);

            if (player == null)
            {
                return NotFound();
            }

            return Ok(player.IndividualGames);
        }

        [HttpGet("{individualgameid}")]
        public ActionResult<IndividualGame> GetIndividualStat(int playerid, int individualstatid)
        {
            //find playe first
            var player = PlayerDataStore.Current.Players
                .FirstOrDefault(p => p.Id == playerid);

            if (player == null)
            {
                return NotFound();
            }

            //find player stat in list of individual game
            var individualStat = player.IndividualGames
                .FirstOrDefault(p => p.Id == individualstatid);
            if (individualStat == null)
            {
                return NotFound();
            }
            return Ok(individualStat);
        }

    }
}
