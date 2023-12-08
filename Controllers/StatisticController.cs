using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class StatisticController : Controller
    {
        private TeamContext context { get; set; }
        public StatisticController(TeamContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var players = context.Player.ToList();
            return View(players);
        }

        public IActionResult Details(int id)
        {
            var statistic = context.Statistics.FirstOrDefault(s => s.Id == id);
            if (statistic == null)
            {
                return NotFound();
            }

            return View(statistic);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var statistic = context.Statistics.Find(id);
            if (statistic == null)
            {
                return NotFound();
            }

            return View(statistic);
        }

        [HttpPost]
        public IActionResult Edit(Statistic statistic)
        {
            if (ModelState.IsValid)
            {
                context.Update(statistic);
                context.SaveChanges();
                return RedirectToAction(nameof(Details), new { id = statistic.Id });
            }
            return View(statistic);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var statistic = context.Statistics.Find(id);
            if (statistic == null)
            {
                return NotFound();
            }

            return View(statistic);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var statistic = context.Statistics.Find(id);
            context.Statistics.Remove(statistic);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Statistic());
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
