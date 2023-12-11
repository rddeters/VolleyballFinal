using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Controllers.Service;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerService _playerService;
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(PlayerService playerService, ILogger<PlayerController> logger)
        {
            _playerService = playerService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {
                var players = _playerService.GetAllPlayers();
                return View(players);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Index action of PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult FilterByPosition(string positiontype)
        {
            try
            {
                var players = _playerService.GetPlayersByPosition(positiontype);
                return View("Index", players);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in FilterByPosition action of PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult Details(int id)
        {
            try
            {
                var player = _playerService.GetPlayerById(id);
                if (player == null) return NotFound();
                return View(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Details action of PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var player = id == 0 ? new Player() : _playerService.GetPlayerById(id);
            if (player == null && id != 0) return NotFound();
            return View(player);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Edit(Player player)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _playerService.AddOrUpdatePlayer(player);
                    return RedirectToAction("Index");
                }
                return View(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Edit action of PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var player = _playerService.GetPlayerById(id);
                if (player == null) return NotFound();
                return View(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Delete[GET] action of PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var player = _playerService.GetPlayerById(id);
                if (player == null) return NotFound();
                _playerService.DeletePlayer(player);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error in Delete[POST] action of PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
