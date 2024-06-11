using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.Blog
{
	public class _BlogListHeadComponentsPartial:ViewComponent
	{ 
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
