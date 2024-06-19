using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
