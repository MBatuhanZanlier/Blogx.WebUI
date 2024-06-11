using Blog.BussinessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blogx.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogx.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]

    public class ChartController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly BlogContext _blogcontex;

        public ChartController(BlogContext blogcontex, ICategoryService categoryService)
        {
            _blogcontex = blogcontex;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCategoryChart()
        {
            var values = _blogcontex.Articles.GroupBy(x => x.CategoryId).Select(y => new ChartViewmodel
            {

                categoryname = _blogcontex.Categories.Where(x => x.CategoryId == y.Key).Select(z => z.CategoryName).FirstOrDefault(),
                count = y.Count(),
            }).ToList();

            return Json(new { jsonlist = values });

        }
    }
}
