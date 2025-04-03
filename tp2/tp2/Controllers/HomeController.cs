using Microsoft.AspNetCore.Mvc;

namespace tp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Acceuil");
        }
    }
}
