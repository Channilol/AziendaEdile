using Microsoft.AspNetCore.Mvc;

namespace AziendaEdile.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
