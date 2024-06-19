using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
