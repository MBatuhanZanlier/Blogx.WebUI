using Blog.BussinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailOrderPostComponentPartial:ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailOrderPostComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _articleService.GetLastFourPost();
            return View(values);
        }
    }
}
