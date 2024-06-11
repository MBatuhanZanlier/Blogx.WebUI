using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutSidebarComponentPartial:ViewComponent
    {  
        private readonly UserManager<AppUser> _userManager;

        public _LayoutSidebarComponentPartial(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ımage = user.ImageUrl; 
            ViewBag.namesurname= user.Name + " " +user.Surname.ToUpper(); 

            return View();
        }
    }
}
