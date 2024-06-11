using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Controllers
{
    public class StatisticController : Controller
    {
        private readonly ICategoryService _categoryService;

        public StatisticController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        { 
            ViewBag.count=_categoryService.TGetCategoryCount();
            return View();
        }
    }
}
