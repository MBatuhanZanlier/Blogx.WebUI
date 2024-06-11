using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.Dashboard
{
    public class DashboardArticleList:ViewComponent
    {
        private readonly IArticleService _articleService;

        public DashboardArticleList(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        { 
            var values=_articleService.TGetAppuserandCategories();
            return View(values);
        }
    }
}
