using Microsoft.AspNetCore.Mvc;
using WebSisPar.Models;

namespace WebSisPar.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            var product = new List<Products>()
            {
                new() {Id=1,
                Name ="Bosch",
                Title ="Bosch Alarm Sistemi",
                Description ="Güvenlik amaçlı Alarm sistemi",
                Price=12500
                },
                 new() {Id=1,
                Name ="Bosch",
                Title ="Bosch Alarm Sistemi",
                Description ="Güvenlik amaçlı Alarm sistemi",
                Price=12500
                },
                  new() {Id=1,
                Name ="Bosch",
                Title ="Bosch Alarm Sistemi",
                Description ="Güvenlik amaçlı Alarm sistemi",
                Price=12500
                }, 
                new() {Id=1,
                Name ="Bosch",
                Title ="Bosch Alarm Sistemi",
                Description ="Güvenlik amaçlı Alarm sistemi",
                Price=12500
                }


            };
			ViewBag.LogoPath = "~/WebPageTemp/build/images/SisPar-Light.png";
			return View(product);
           

		}
    }
}
