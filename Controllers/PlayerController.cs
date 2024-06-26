﻿using Microsoft.AspNetCore.Mvc;
using rugby_stat_tracker.Interfaces;
using rugby_stat_tracker.Models;

namespace rugby_stat_tracker.Controllers
{
    //generic api endpoint name, could use [controller] but would like endpoint to stay same even during refactoring.
    [Route("api/players")]
    [Produces("application/json")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerRepository _playerRepository;
        public PlayerController(IPlayerRepository playerRepository) {
            _playerRepository = playerRepository ?? throw new ArgumentNullException(nameof(playerRepository));
        }

        //GET all players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            var playerEntities = await _playerRepository.GetAllPlayersAsync();
            return Ok(playerEntities);
        }
        
        //GET player by id
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id, bool includeIndividualGames)
        {

            var playerEntity = await _playerRepository.GetByPlayerIdAsync(id, includeIndividualGames);

            if (playerEntity == null)
            {
                return NotFound();
            }

            return Ok(playerEntity);
        }

        [HttpPost]
        public async Task<ActionResult<Player>> CreatePlayer([FromBody]Player player)
        {
            try
            {
                if (player == null)
                    return BadRequest();

                var createdPlayer = await _playerRepository.CreatePlayer(player);

                return CreatedAtAction(nameof(CreatePlayer),
                    new { id = createdPlayer.Id }, createdPlayer);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error creating new player record");
            }
        }
    }
}
