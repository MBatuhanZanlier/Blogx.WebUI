using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailByBlogContentComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleservice;

        public _BlogDetailByBlogContentComponentPartial(IArticleService articleservice)
        {
            _articleservice = articleservice;
        }

        public IViewComponentResult Invoke(int id)
        { 
            var values=_articleservice.TGetbyId(id);
            return View(values);
        }
    }
}
