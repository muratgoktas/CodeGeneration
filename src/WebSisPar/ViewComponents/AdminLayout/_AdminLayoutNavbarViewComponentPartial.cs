using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
