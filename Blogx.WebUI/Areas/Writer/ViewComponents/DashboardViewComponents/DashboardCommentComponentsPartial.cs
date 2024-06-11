using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{
    public class DashboardCommentComponentsPartial : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICommentService _commentService;  

        public DashboardCommentComponentsPartial(UserManager<AppUser> userManager, ICommentService commentService)
        {
            _userManager = userManager;
            _commentService = commentService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = _commentService.TGetCommentByArticleıdArticlandAppuser(id);
            return View(values);
        }
    }
}
