using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
