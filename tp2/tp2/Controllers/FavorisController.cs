using Microsoft.AspNetCore.Mvc;

namespace tp2.Controllers
{
    public class FavorisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
