using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsApiController : ControllerBase
    {
        private readonly TeamContext _context;

        public StatisticsApiController(TeamContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Statistic>>> GetStatistics()
        {
            return await _context.Statistics.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Statistic>> GetStatistics(int id)
        {
            var statistic = await _context.Statistics.FindAsync(id);

            if (statistic == null)
            {
                return NotFound();
            }

            return statistic;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Statistic statistic)
        {
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetStatistics), new { id = statistic.Id }, statistic);
        }

        public async Task<IActionResult> Update(int id, [FromBody] Statistic statistic)
        {
            if (id != statistic.Id) return BadRequest();
            _context.Entry(statistic).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var statistic = await _context.Statistics.FindAsync(id);
            if (statistic == null) return NotFound();
            _context.Statistics.Remove(statistic);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}

