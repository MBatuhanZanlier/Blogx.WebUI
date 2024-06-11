using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.Blog
{
	public class _BlogListComponentPartial:ViewComponent
	{
		private readonly IArticleService _articleService;

		public _BlogListComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		} 
		public IViewComponentResult Invoke()
		{
			var values = _articleService.TGetArticleWither(); 
			return View(values);
		}
	}
}
