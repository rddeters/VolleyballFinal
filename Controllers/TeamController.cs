using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class TeamController : Controller
    {
        private readonly TeamContext context;
        private readonly ILogger<TeamController> _logger;

        public TeamController(TeamContext ctx, ILogger<TeamController> logger)
        {
            context = ctx;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var teams = context.Teams.ToList();
                return View(teams);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Index action of TeamController");
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult FilterByLeague(string leaguetype)
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in TeamController");
                return RedirectToAction("Error", "Home");
            } 
        }

        public IActionResult Details(int id)
        {
            try
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
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in TeamController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            try
            {
                ViewBag.Action = "Edit";
                var team = context.Teams.Find(id);
                return View(team);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in TeamController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Edit(Team team)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (team.Id == 0) context.Teams.Add(team);
                    else context.Teams.Update(team);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Action = (team.Id == 0) ? "Add" : "Edit";
                    return View(team);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in TeamController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var team = context.Teams.Find(id);
                return View(team);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in TeamController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Delete(Team team)
        {
            try
            {
                context.Teams.Remove(team);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in TeamController");
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
