using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.Blog
{
	public class _BlogListNavbarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View(); 
		}
	}
}
