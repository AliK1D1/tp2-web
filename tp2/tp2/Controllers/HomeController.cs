using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers
{
    
    public class HomeController : Controller
    {
        private  BaseDeDonnees _db;

        public HomeController( BaseDeDonnees bd)
        {
            _db = bd;
        }


        public IActionResult Index()
        {
            var c = _db.Combattants;
            return View(c);
        }




    }
}
