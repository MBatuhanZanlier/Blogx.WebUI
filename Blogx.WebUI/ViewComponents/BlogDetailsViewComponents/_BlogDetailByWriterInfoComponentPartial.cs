using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailByWriterInfoComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailByWriterInfoComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetWriterİnfoByWriterId(id);
            return View(values);
           
        }
    }
}
