using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using WebSisPar.Services;

namespace WebSisPar.Controllers
{
    public class CoreController : Controller
    {
        private LanguageService _localization;
        public CoreController(LanguageService localization)
        {
            _localization = localization;
        }
        public IActionResult Index()
        {
            ViewBag.Welcome = _localization.GetKey("Welcome").Value;
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;
            return View();
        }
        public IActionResult Feature() 
        {
            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
		public IActionResult Support()
		{
			return View();
		}
        public IActionResult SignIn()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult Solutation()
        {
            return View();
        }
        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
               CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions()
               {
                   Expires = DateTimeOffset.UtcNow.AddYears(1)
               });
            return Redirect(Request.Headers["Referer"].ToString());
        }
        
    }
}
