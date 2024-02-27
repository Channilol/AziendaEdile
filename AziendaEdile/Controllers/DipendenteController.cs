using AziendaEdile.Models;
using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile.Controllers
{
    public class DipendenteController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticDB.GetAll());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string Nome, string Cognome, string Indirizzo, string CodiceFiscale, bool Coniugato, int NumFigli, string Mansione)
        {
            var dipendente = StaticDB.Add(Nome, Cognome, Indirizzo, CodiceFiscale, Coniugato, NumFigli, Mansione);
            return RedirectToAction("Index");
        }
    }
}