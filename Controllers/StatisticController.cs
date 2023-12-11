using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyballFinal.Controllers.Service;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class StatisticController : Controller
    {
        private readonly StatisticService _statisticService;
        private readonly ILogger<StatisticController> _logger;

        public StatisticController(StatisticService statisticService, ILogger<StatisticController> logger)
        {
            _statisticService = statisticService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var statistics = _statisticService.GetAllStatistics();
                return View(statistics);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Index action of StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                var statistic = _statisticService.GetStatisticById(id);
                if (statistic == null)
                {
                    return RedirectToAction(nameof(Add), new { id = id });
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Details action of StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                var statistic = _statisticService.GetStatisticById(id);
                if (statistic == null)
                {
                    return NotFound();
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Edit[GET] action of StatisticController");
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
                    _statisticService.AddOrUpdateStatistic(statistic);
                    return RedirectToAction(nameof(Details), new { id = statistic.Id });
                }
                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Edit[POST] action of StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var statistic = _statisticService.GetStatisticById(id);
                if (statistic == null)
                {
                    return NotFound();
                }

                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Delete[GET] action of StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var statistic = _statisticService.GetStatisticById(id);
                if (statistic == null)
                {
                    return NotFound();
                }

                _statisticService.DeleteStatistic(statistic);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Delete[POST] action of StatisticController");
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
                _logger.LogError(ex, "Error in Add[GET] action of StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Add(Statistic statistic)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _statisticService.AddOrUpdateStatistic(statistic);
                    return RedirectToAction(nameof(Details), new { id = statistic.Id });
                }
                return View(statistic);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Add[POST] action of StatisticController");
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
