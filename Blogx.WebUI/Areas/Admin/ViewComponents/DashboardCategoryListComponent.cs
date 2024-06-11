using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents
{
    public class DashboardCategoryListComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public DashboardCategoryListComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetlistAll().OrderBy(x => x.CategoryId).ToList();
            return View(values);
        }
    }
}
