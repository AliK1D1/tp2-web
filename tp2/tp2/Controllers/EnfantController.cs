using Microsoft.AspNetCore.Mvc;

namespace tp2.Controllers
{
    public class EnfantController : Controller
    {
        public IActionResult recherche()
        {
            return View("recherche");
        }
        public IActionResult detail()
        {
            return View("detail");
        }
    }
}
