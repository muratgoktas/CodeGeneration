using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.AdminLayout
{
    public class _AdminLayoutJavaScriptViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
