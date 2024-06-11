using Blog.BussinessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.Dashboard
{
    public class DashboardWigerCardComponent:ViewComponent
    {
        private readonly IArticleService _articleService;
        private readonly BlogContext _blogContext;
        private readonly UserManager<AppUser> _userManager;
        public DashboardWigerCardComponent(IArticleService articleService, BlogContext blogContext, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _blogContext = blogContext;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.articlecount=_blogContext.Articles.ToList().Count;
            ViewBag.messagebox = _blogContext.Messages.Where(x => x.ReceiverMail == user.Email).ToList().Count();
            ViewBag.sendmessage = _blogContext.Messages.Where(x => x.SenderMail == user.Email).ToList().Count(); 
            ViewBag.categorycount=_blogContext.Categories.ToList().Count;
            return View();
        }
    }
}
