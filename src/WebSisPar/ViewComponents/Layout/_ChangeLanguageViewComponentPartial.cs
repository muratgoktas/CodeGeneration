using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.Layout
{
    public class _ChangeLanguageViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
