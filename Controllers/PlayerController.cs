using Microsoft.AspNetCore.Mvc;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class PlayerController : Controller
    {
        private TeamContext context { get; set; }
        public PlayerController(TeamContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Player());
        }

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
            if (ModelState.IsValid)
            {
                if (player.Id == 0) context.Player.Add(player);
                else context.Player.Update(player);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (player.Id == 0) ? "Add" : "Edit";
                return View(player);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var player = context.Player.Find(id);
            return View(player);
        }

        [HttpPost]
        public IActionResult Delete(Player player)
        {
            context.Player.Remove(player);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
