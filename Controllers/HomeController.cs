using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VolleyballFinal.Models;

namespace VolleyballFinal.Controllers
{
    public class HomeController : Controller
    {
        private TeamContext context { get; set; }
        public HomeController(TeamContext ctx) => context = ctx;

        public IActionResult Index()
        {
            var teams = context.Teams.OrderBy(t => t.TeamName).ToList();
            return View(teams);
        }
    }
}

