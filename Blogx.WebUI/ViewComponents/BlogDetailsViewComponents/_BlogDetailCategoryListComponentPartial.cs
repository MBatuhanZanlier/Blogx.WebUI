using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailCategoryListComponentPartial:ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _BlogDetailCategoryListComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        } 
        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetlistAll().Take(5).ToList();
            return View(values);    
        }
    }
}
