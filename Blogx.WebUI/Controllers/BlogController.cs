using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICommentService _commentService;
        private readonly IArticleService _articleService;
        public BlogController(UserManager<AppUser> userManager, ICommentService commentService, IArticleService articleService)
        {
            _userManager = userManager;
            _commentService = commentService;
            _articleService = articleService;
        }

        public IActionResult BlogList(string search)
		{
			if (!string.IsNullOrEmpty(search))
			{
				var articles = _articleService.TGetSearchBlogs(search);
				ViewBag.Search = search;
				return View(articles);
			}
			else
			{
				var values = _articleService.TGetArticleWither();
				return View(values);

			}
		
        }
        public IActionResult BlogDetail(int id)
        {
            ViewBag.i = id;
            return View();
        }
        public async Task<IActionResult> BlogComment(Comment comment)
        {

            var users = await _userManager.FindByNameAsync(User.Identity.Name);
            comment.AppUserId = users.Id;
            comment.CommentDate = DateTime.Now;
            comment.Status = true;
            _commentService.TInsert(comment);
            return RedirectToAction("BlogList");
        }


    }
}
