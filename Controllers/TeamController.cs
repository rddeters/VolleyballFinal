using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class TeamController : Controller
    {
        private TeamContext context { get; set; }
        public TeamController(TeamContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Team());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var team = context.Teams.Find(id);
            return View(team);
        }

        [HttpPost]
        public IActionResult Edit(Team team)
        {
            if(ModelState.IsValid)
            {
                if(team.Id == 0)context.Teams.Add(team);
                else context.Teams.Update(team);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            } else
            {
                ViewBag.Action = (team.Id == 0) ? "Add" : "Edit";
                return View(team);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var team = context.Teams.Find(id);
            return View(team);
        }

        [HttpPost]
        public IActionResult Delete(Team team)
        {
            context.Teams.Remove(team);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
