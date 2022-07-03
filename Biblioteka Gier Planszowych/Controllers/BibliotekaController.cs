using Biblioteka_Gier_Planszowych.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteka_Gier_Planszowych.Controllers
{
    public class BibliotekaController : Controller
    {
        // GET: BibliotekaController
        public ActionResult Biblioteka()
        {
            List<Gra_Planszowa> games = new List<Gra_Planszowa>();
            using (var db = new BibliotekaContext())
            {
                games = db.Gra_Planszowa.ToList();

                ViewBag.games = games;  
            }
            return View();
        }
        

        // GET: BibliotekaController/Create
        public ActionResult DodajGre()
        {
            
           
                return View();
        }

        // POST: BibliotekaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DodajGre(Gra_Planszowa gra_planszowa)
        {
            
                using (var db = new BibliotekaContext())
                {
                    gra_planszowa.Login = HttpContext.Session.GetString("Login");
                    db.Add(gra_planszowa);
                    db.SaveChanges();
                }
                return RedirectToAction("Biblioteka");
            
            

        }

        // GET: BibliotekaController/Edit/5
        public ActionResult Edytuj(int id)
        {
            using (var db = new BibliotekaContext())
            {
                var updategra = db.Gra_Planszowa.Where(g => g.Id == id).FirstOrDefault();

                ViewBag.gra = updategra;
            }
            return View();
        }

        // POST: BibliotekaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edytuj(Gra_Planszowa gra_planszowa)
        {
            using (var db = new BibliotekaContext())
            {
                var edytujgra = db.Gra_Planszowa.Where(g => g.Id == gra_planszowa.Id).FirstOrDefault();

                edytujgra.Tytuł = gra_planszowa.Tytuł;
                edytujgra.Opis = gra_planszowa.Opis;
                edytujgra.Gatunek = gra_planszowa.Gatunek;
                edytujgra.Wydawca = gra_planszowa.Wydawca;

                db.SaveChanges();
            }
            return RedirectToAction("Biblioteka", "Biblioteka", new { area = "" });
        }

        // GET: BibliotekaController/Delete/5
        public ActionResult Delete(int id)
        {
            var gra = new Gra_Planszowa() { Id = id };
            using (var db = new BibliotekaContext())
            {
                
                db.Attach(gra);
                db.Remove(gra);
                db.SaveChanges();
            }
            return RedirectToAction("Biblioteka", "Biblioteka", new { area = "" });
        }

        // POST: BibliotekaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
