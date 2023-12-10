using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class PlayerController : Controller
    {
        private readonly TeamContext context;
        private readonly ILogger<PlayerController> _logger;

        public PlayerController(TeamContext ctx, ILogger<PlayerController> logger)
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

        public IActionResult FilterByPosition(string positiontype)
        {
            IEnumerable<Player> players;
            try
            {
                if (positiontype.ToLower() == "all")
                {
                    players = context.Player.OrderBy(p => p.PlayerName).ToList();
                }
                else
                {
                    positiontype = positiontype.ToLower();
                    players = context.Player.Where(p => p.Position.ToLower() == positiontype)
                                         .OrderBy(p => p.PlayerName).ToList();
                }

                return View("Index", players);
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
                var player = context.Player.FirstOrDefault(p => p.PlayerId == id);
                if (player == null)
                {
                    return NotFound();
                }

                return View(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var player = context.Player.Find(id);
            return View(player);
        }
        
        [HttpPost]
        public IActionResult Edit(Player player)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (player.PlayerId == 0) context.Player.Add(player);
                    else context.Player.Update(player);
                    context.SaveChanges();
                    return RedirectToAction("Index", "Player");
                }
                else
                {
                    ViewBag.Action = (player.PlayerId == 0) ? "Add" : "Edit";
                    return View(player);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [Authorize]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            try
            {
                var player = context.Player.Find(id);
                return View(player);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public IActionResult Delete(Player player)
        {
            try
            {
                context.Player.Remove(player);
                context.SaveChanges();
                return RedirectToAction("Index", "Player");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while processing request in PlayerController");
                return RedirectToAction("Error", "Home");
            }
        }
    }
}
