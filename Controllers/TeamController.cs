using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class TeamController : Controller
    {
        private TeamContext context { get; set; }
        public TeamController(TeamContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var teams = context.Teams.ToList(); 
            return View(teams); 
        }

        public IActionResult FilterByLeague(string leaguetype)
        {
            IEnumerable<Team> teams;

            if (leaguetype.ToLower() == "all")
            {
                teams = context.Teams.OrderBy(t => t.TeamName).ToList();
            }
            else
            {
                leaguetype = leaguetype.ToLower();
                teams = context.Teams.Where(t => t.LeagueType.ToLower() == leaguetype)
                                     .OrderBy(t => t.TeamName).ToList();
            }

            return View("Index", teams);
        }

        public IActionResult Details(int id)
        {
            var team = context.Teams.FirstOrDefault(t => t.Id == id);
            if (team == null)
            {
                return NotFound();
            }

            var players = context.Player.Where(p => p.TeamName == team.TeamName).ToList();

            var viewModel = new TeamDetailsViewModel
            {
                Team = team,
                Players = players
            };

            return View(viewModel);
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
