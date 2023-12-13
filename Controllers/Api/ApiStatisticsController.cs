using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiStatisticsController : ControllerBase
    {
        private readonly TeamContext _context;

        public ApiStatisticsController(TeamContext context)
        {
            _context = context;
        }

        // GET: api/ApiStatistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Statistic>>> GetStatistics()
        {
          if (_context.Statistics == null)
          {
              return NotFound();
          }
            return await _context.Statistics.ToListAsync();
        }

        // GET: api/ApiStatistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Statistic>> GetStatistic(int id)
        {
          if (_context.Statistics == null)
          {
              return NotFound();
          }
            var statistic = await _context.Statistics.FindAsync(id);

            if (statistic == null)
            {
                return NotFound();
            }

            return statistic;
        }

        // PUT: api/ApiStatistics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatistic(int id, Statistic statistic)
        {
            if (id != statistic.Id)
            {
                return BadRequest();
            }

            _context.Entry(statistic).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatisticExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ApiStatistics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Statistic>> PostStatistic(Statistic statistic)
        {
          if (_context.Statistics == null)
          {
              return Problem("Entity set 'TeamContext.Statistics'  is null.");
          }
            _context.Statistics.Add(statistic);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatistic", new { id = statistic.Id }, statistic);
        }

        // DELETE: api/ApiStatistics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatistic(int id)
        {
            if (_context.Statistics == null)
            {
                return NotFound();
            }
            var statistic = await _context.Statistics.FindAsync(id);
            if (statistic == null)
            {
                return NotFound();
            }

            _context.Statistics.Remove(statistic);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatisticExists(int id)
        {
            return (_context.Statistics?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
