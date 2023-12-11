using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyballFinal.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace VolleyballFinal.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersApiController : ControllerBase
    {
        private readonly TeamContext _context;

        public PlayersApiController(TeamContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            return await _context.Player.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            var player = await _context.Player.FindAsync(id);
            if (player == null) return NotFound();
            return player;
        }

        [HttpPost]
        public async Task<ActionResult<Player>> Create([FromBody] Player player)
        {
            _context.Player.Add(player);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPlayer), new { id = player.PlayerId }, player);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] Player player)
        {
            if (id != player.PlayerId) return BadRequest();
            _context.Entry(player).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var player = await _context.Player.FindAsync(id);
            if (player == null) return NotFound();
            _context.Player.Remove(player);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
