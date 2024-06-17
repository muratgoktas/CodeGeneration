using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.Layout
{
    public class _CTAStartBannerViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
