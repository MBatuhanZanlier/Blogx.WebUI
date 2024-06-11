using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogx.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly ICommentService _commentService;
        public BlogController(UserManager<AppUser> userManager, IArticleService articleService, ICategoryService categoryService, ICommentService commentService)
        {
            _userManager = userManager;
            _articleService = articleService;
            _categoryService = categoryService;
            _commentService = commentService;
        }

        public async Task<IActionResult> MyBlogList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.id = user.Id + " " + user.Name + " " + user.Surname;  
            var values = _articleService.TGetArticlesByWriter(user.Id);
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateBlog()
        {
            List<SelectListItem> values = (from x in _categoryService.TGetlistAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(Article article)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            article.AppUserId = user.Id;
            article.CreatedDate = DateTime.Now;
            _articleService.TInsert(article);
            return RedirectToAction("MyBlogList");
        }
        public IActionResult DeleteBlog(int id)
        {

            _articleService.TDelete(id);
            return RedirectToAction("MyBlogList");
        }
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> values = (from x in _categoryService.TGetlistAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = _articleService.TGetbyId(id);
            return View(value);


        }
        [HttpPost]
        public async Task<IActionResult> EditBlog(Article article)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            article.AppUserId = user.Id;
            article.UpdateDate = DateTime.Now;

            _articleService.TUpdate(article);

            return RedirectToAction("MyBlogList");
        }
        public async Task<IActionResult> BlogComment(Article article)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name); 
            article.ArticleId=user.Id;
            var value = _commentService.TGetCommentsByArticleıd(article.ArticleId);
            return View(value);
        } 
        public IActionResult BlogArticleComment(int id)
        {
            var values = _commentService.TGetCommentByArticleıdArticlandAppuser(id);
            return View(values);
        }
    }
}
