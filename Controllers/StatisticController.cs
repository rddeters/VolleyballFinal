using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class StatisticController : Controller
    {
        private TeamContext context { get; set; }
        private readonly ILogger<StatisticController> _logger;

        public StatisticController(TeamContext ctx, ILogger<StatisticController> logger)
        {
            context = ctx;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var players = context.Player.ToList();
                return View(players);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }
        public IActionResult Details(int id)
        {
            try
            {
                var statistic = context.Statistics.FirstOrDefault(s => s.Id == id);
                if (statistic == null)
                {
                    return RedirectToAction(nameof(Add), new { id = id });
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var statistic = context.Statistics.Find(id);
                if (statistic == null)
                {
                    return NotFound();
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Edit(Statistic statistic)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Update(statistic);
                    context.SaveChanges();
                    return RedirectToAction(nameof(Details), new { id = statistic.Id });
                }
                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var statistic = context.Statistics.Find(id);
                if (statistic == null)
                {
                    return NotFound();
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var statistic = context.Statistics.Find(id);
                context.Statistics.Remove(statistic);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Add(int? id)
        {
            try
            {
                var statistic = new Statistic();
                if (id.HasValue)
                {
                    statistic.Id = id.Value;
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Add(Statistic statistic)
        {
            if (ModelState.IsValid)
            {
                context.Add(statistic);
                context.SaveChanges();
                return RedirectToAction(nameof(Details), new { id = statistic.Id });
            }
            return View(statistic);
        }

    }
}
