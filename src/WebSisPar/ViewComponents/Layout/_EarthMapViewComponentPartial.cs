using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.Layout
{
    public class _EarthMapViewComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
