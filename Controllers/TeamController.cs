using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Controllers.Service;
using VolleyballFinal.Models;

public class TeamController : Controller
{
    private readonly TeamService _teamService;
    private readonly ILogger<TeamController> _logger;

    public TeamController(TeamService teamService, ILogger<TeamController> logger)
    {
        _teamService = teamService;
        _logger = logger;

    }

    public IActionResult Index()
    {
        try
        {
            var teams = _teamService.GetAllTeams();
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
            var teams = _teamService.GetTeamsByLeague(leaguetype);
            return View("Index", teams);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in FilterByLeague action of TeamController");
            return RedirectToAction("Error", "Home");
        }
    }

    public IActionResult Details(int id)
    {
        try
        {
            var team = _teamService.GetTeam(id);
            if (team == null)
            {
                return NotFound();
            }

            var players = _teamService.GetPlayersByTeamName(team.TeamName);
            var viewModel = new TeamDetailsViewModel
            {
                Team = team,
                Players = players
            };

            return View(viewModel);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in Details action of TeamController");
            return RedirectToAction("Error", "Home");
        }
    }

    [Authorize]
    [HttpGet]
    public IActionResult Edit(int id)
    {
        try
        {
            var team = _teamService.GetTeam(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in Edit[GET] action of TeamController");
            return RedirectToAction("Error", "Home");
        }
    }

    [Authorize]
    [HttpPost]
    public IActionResult Edit(Team team)
    {
        try
        {
            if (ModelState.IsValid)
            {
                _teamService.UpdateTeam(team);
                return RedirectToAction("Index");
            }

            return View(team);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in Edit[POST] action of TeamController");
            return RedirectToAction("Error", "Home");
        }
    }

    [Authorize]
    [HttpGet]
    public IActionResult Delete(int id)
    {
        try
        {
            var team = _teamService.GetTeam(id);
            if (team == null)
            {
                return NotFound();
            }

            return View(team);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in Delete[GET] action of TeamController");
            return RedirectToAction("Error", "Home");
        }
    }

    [Authorize]
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        try
        {
            var team = _teamService.GetTeam(id);
            if (team == null)
            {
                return NotFound();
            }

            _teamService.DeleteTeam(team);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error in Delete[POST] action of TeamController");
            return RedirectToAction("Error", "Home");
        }
    }
}
