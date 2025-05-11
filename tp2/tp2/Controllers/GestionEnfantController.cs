using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tp2.Models;

namespace tp2.Controllers
{
    public class GestionEnfantController : Controller
    {

        private BaseDeDonnees _db { get; set; }

        public GestionEnfantController(BaseDeDonnees bd)
        {
            _db = bd;
        }

        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int id)
        {
            var combattant = _db.Combattants.FirstOrDefault(c => c.Id == id);
            if (combattant == null)
            {
                return NotFound();
            }

            return View(combattant); // Affiche la vue de confirmation avec les infos du combattant
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var combattant = _db.Combattants.FirstOrDefault(c => c.Id == id);
                if (combattant == null)
                {
                    return NotFound();
                }

                _db.Combattants.Remove(combattant); // Supprime le combattant

                return RedirectToAction("Index","home"); 
            }
            catch
            {
                return View();
            }
        }
    }
}
