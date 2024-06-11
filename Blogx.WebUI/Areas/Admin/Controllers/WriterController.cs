using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class WriterController : Controller
    {
        private readonly IArticleService _articleService;

        public WriterController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IActionResult Index()
        {
            var values = _articleService.TGetAppuserandCategories();
            return View(values);
        } 
        public IActionResult DeleteBlog(int id) 
        { 
           _articleService.TDelete(id); 
            return RedirectToAction("Index");
        }
    }
}
