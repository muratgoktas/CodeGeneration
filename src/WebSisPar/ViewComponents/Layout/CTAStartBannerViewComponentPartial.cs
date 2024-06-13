using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.Layout
{
    public class CTAStartBannerViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
