using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.Blog
{
	public class _FooterComponentPartial : ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
