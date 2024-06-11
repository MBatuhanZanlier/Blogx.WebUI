using Blog.BussinessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{
    public class DashboardWigetCardComponentsPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager; 
        private readonly BlogContext _blogContext;

        public DashboardWigetCardComponentsPartial(BlogContext blogContext, UserManager<AppUser> userManager)
        {
            _blogContext = blogContext;
            _userManager = userManager;
        }

        public async Task <IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.sendmessage= _blogContext.Messages.Where(x => x.SenderMail == user.Email).ToList().Count();
            ViewBag.articleCount = _blogContext.Articles.Where(x => x.AppUserId == user.Id).ToList().Count();
            ViewBag.messagebox = _blogContext.Messages.Where(x => x.ReceiverMail == user.Email).ToList().Count();
            ViewBag.commentcount = _blogContext.Comments.Where(x => x.AppUserId == user.Id).ToList().Count(); 
            return  View();
        }
    }
}
