using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{ 
    
    public class _BlogDetailByCoverInfoComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

		public _BlogDetailByCoverInfoComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke(int id)
        { 
            var values=_articleService.TGetArticleByWriterAndCategori(id);
            return View(values);
        }
    }
}
