using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetlistAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {

            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            if (category != null)
            {
                _categoryService.TInsert(category);
                return RedirectToAction("CategoryList");
            }
            return View();


        }
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("CategoryList");
        }
        [HttpGet]
        public IActionResult EditCategory(int id) 
        {  var values=_categoryService.TGetbyId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditCategory(Category category)
        { 
            _categoryService.TUpdate(category);
            return RedirectToAction("CategoryList");
        }
    }
}
