using Biblioteka_Gier_Planszowych.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Biblioteka_Gier_Planszowych.Controllers
{
    public class UzytkownikController : Controller
    {
        public IActionResult NowyUzytkownik()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NowyUzytkownik(Uzytkownik uzytkownik)
        {
            if (ModelState.IsValid)
            {
                using (var db = new BibliotekaContext())
                {
                    uzytkownik.Haslo = BCrypt.Net.BCrypt.HashPassword(uzytkownik.Haslo);

                    db.Add(uzytkownik);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View(uzytkownik);
        }
        
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Uzytkownik uzytkownik)
        {
            using (var db = new BibliotekaContext())
            {
                bool verify = false;
                var usr = db.Users.SingleOrDefault(u => u.Login == uzytkownik.Login);
                
                if (usr != null)
                { 
                verify = BCrypt.Net.BCrypt.Verify(uzytkownik.Haslo, usr.Haslo);
                }
                if (usr != null && verify)
                {
                    HttpContext.Session.SetString("UserId", usr.Id.ToString());
                    HttpContext.Session.SetString("Login", usr.Login.ToString());
                    HttpContext.Session.SetInt32("Admin", usr.Uprawnienia);


                 
                    return RedirectToAction("Biblioteka", "Biblioteka", new { area = "" });
                }
                else
                {
                    if (uzytkownik.Haslo != null && uzytkownik.Login != null)
                    { 
                    ViewBag.message = "Login lub hasło są nieprawidłowe";
                    }
                    ModelState.AddModelError("", "Login lub hasło są nieprawidłowe");
                    return View();
                }
            }
        }
      
        public IActionResult Wyloguj()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}
