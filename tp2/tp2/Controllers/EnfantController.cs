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

        [Route("Enfant/recherche")]
        public IActionResult recherche()
		{
			var combattants = _db.Combattants;
			return View(combattants);
		}






		[Route("Enfant/detail/{value}")]
		[Route("Enfant/{value}")]
		[Route("/{value}")]
		public IActionResult detail(string value)
		{


            Combattant combattant = null;

            if (int.TryParse(value, out int id))
            {
                
                combattant = _db.Combattants.FirstOrDefault(c => c.Id == id);
            }
            else
            {
                
                combattant = _db.Combattants.FirstOrDefault(c =>
                    c.Nom.Replace(" ", "").ToLower() == value.Replace(" ", "").ToLower()
                );
            }

            if (combattant == null)
            {
                return View("NotFound");
            }

            return View(combattant);

        }
	}
}
