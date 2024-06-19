using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
