using Microsoft.AspNetCore.Mvc;

namespace tp2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Acceuil");
        }

        public IActionResult recherche()
        {
            return View("recherche");
        }
        public IActionResult favoris()
        {
            return View("favoris");
        }
        public IActionResult detail()
        {
            return View("detail");
        }


    }
}
