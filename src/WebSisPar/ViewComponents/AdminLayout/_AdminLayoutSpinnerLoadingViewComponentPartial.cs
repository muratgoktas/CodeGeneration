using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.AdminLayout
{
    public class _AdminLayoutSpinnerLoadingViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
