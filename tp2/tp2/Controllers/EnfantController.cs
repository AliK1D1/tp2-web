using Microsoft.AspNetCore.Mvc;
using tp2.Models;
using tp2.ViewModels;

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
            var model = new PageRechercheViewMode();
            model.Critere = new CritereRechercheViewModel();
            model.Critere.PoidLourd = true;
            model.Critere.PoidMoyen = true;
            model.Critere.PoidPlume = true;
            model.Critere.Champ = "oui";
            model.Critere.max = 4;
            model.Critere.min = 1;
            model.Critere.MotCles = "hello";
            model.Resultat = _db.Combattants.ToList();

			
            
          //  var combattants = _db.Combattants;
			return View(model);
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

            return View(combattant); //Kevin ne t'enleverea pas de point return view("detail, combattant")

        }
	}
}
