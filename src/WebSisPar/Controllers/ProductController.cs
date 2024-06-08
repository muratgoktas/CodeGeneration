using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
