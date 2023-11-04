using Microsoft.AspNetCore.Mvc;

namespace VolleyballFinal.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
