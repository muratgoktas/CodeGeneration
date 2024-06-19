using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
