using Microsoft.AspNetCore.Mvc;

namespace WebSisPar.ViewComponents.Layout
{
	public class _HeadViewComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke() 
		{ 
			return View();
		}
	}
}
