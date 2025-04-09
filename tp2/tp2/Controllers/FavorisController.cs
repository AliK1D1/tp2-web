using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers
{
	public class FavorisController : Controller
	{
		private BaseDeDonnees _db;
		public FavorisController(BaseDeDonnees bd)
		{
			_db = bd;
		}
		public IActionResult Index()
		{
			var combattant = _db.Combattants;
			return View(combattant);
		}
	}
}
