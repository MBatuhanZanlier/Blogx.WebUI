using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{
    public class DashboardCategoryListComponentPartial : ViewComponent
    { 
        private readonly ICategoryService _categoryService;

        public DashboardCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetlistAll();
            return View(values); 
        }
    }
}
