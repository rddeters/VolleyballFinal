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
            return View();
        }
    }
}
