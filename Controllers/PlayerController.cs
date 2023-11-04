using Microsoft.AspNetCore.Mvc;

namespace VolleyballFinal.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
