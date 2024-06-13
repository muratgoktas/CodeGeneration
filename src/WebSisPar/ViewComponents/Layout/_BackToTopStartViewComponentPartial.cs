using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.Layout
{
    public class _BackToTopStartViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
