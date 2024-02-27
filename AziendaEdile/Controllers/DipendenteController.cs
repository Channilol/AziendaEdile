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
    }
}