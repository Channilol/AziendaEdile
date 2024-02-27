using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile.Controllers
{
    public class PagamentiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }
    }
}