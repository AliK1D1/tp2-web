using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers
{
	public class EnfantController : Controller
	{
		private BaseDeDonnees _db { get; set; }

		public EnfantController(BaseDeDonnees bd)
		{
			_db = bd;
		}

		public IActionResult recherche()
		{
			var combattants = _db.Combattants;
			return View(combattants);
		}
		[Route("Enfant/detail/{id:int}")]
		[Route("Enfant/{id:int}")]
		[Route("/{id:int}")]
		public IActionResult detail(int id)
		{
			var combattant = _db.Combattants.FirstOrDefault(c => c.Id == id);

			if (combattant == null)
			{
				return View("NotFound"); 
			}

			return View(combattant);
			
		}
	}
}
