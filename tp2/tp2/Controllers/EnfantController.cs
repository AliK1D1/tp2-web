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
            var model = new PageRechercheViewModel();
            model.Critere = new CritereRechercheViewModel();
            model.Critere.PoidLourd = true;
            model.Critere.PoidMoyen = true;
            model.Critere.PoidPlume = true;
            model.Critere.Champ = "oui";
            model.Critere.max = 100;
            model.Critere.min = 18;
            model.Critere.MotCles = "alex";
            model.Resultat = _db.Combattants.ToList();

			
            
          //  var combattants = _db.Combattants;
			return View(model);
		}

        [Route("Enfant/Filtrer")]
        public IActionResult Filtrer(CritereRechercheViewModel critere) {
          
            IEnumerable<Combattant> donnees = _db.Combattants.AsQueryable();

            if (critere.PoidPlume || critere.PoidMoyen || critere.PoidLourd)
            {
                donnees = donnees.Where(c =>
                    (critere.PoidPlume && c.Poid == "Poids Plume") ||
                    (critere.PoidMoyen && c.Poid == "Poids Moyen") ||
                    (critere.PoidLourd && c.Poid == "Poids Lourd")
                );
            }
            if (critere.Champ == "oui")
            {
                donnees = donnees.Where(c => c.EstChampion == true);
            }
            else if (critere.Champ == "non")
            {
                donnees = donnees.Where(c => c.EstChampion == false);
            }
            else if (critere.Champ == "peut importe")
            {
               // donnees = donnees.Where(c => c.Age.ToString().Contains(critere.MotCles.ToString())).ToList();
            }

            if (critere.MotCles != null)
            {
                donnees = donnees.Where(c => c.Nom.ToLower().Contains(critere.MotCles.ToLower()));
            }

            if (critere.min != 0 && critere.max !=0)
            {
                donnees = donnees.Where(c => c.Age >= critere.min && c.Age <= critere.max);
            }

            var model = new PageRechercheViewModel();
            model.Resultat = donnees.ToList();
            model.Critere = critere;

            return View("recherche",model);
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
