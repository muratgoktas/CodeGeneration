using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.Controllers
{
    public class CoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
