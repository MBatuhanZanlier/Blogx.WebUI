using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailGetOtherBlogPostByWriter:ViewComponent
    {  
        private readonly IArticleService _articleService;

        public _BlogDetailGetOtherBlogPostByWriter(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        { var values=_articleService.TGetlistAll().Where(x=>x.ArticleId!= id).OrderBy(y=>y.CreatedDate).Take(4).ToList();
            return View(values);
        }
    }
}
