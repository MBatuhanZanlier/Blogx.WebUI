using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class _AdminLayoutProfileSettingComponent:ViewComponent
    {  
        private readonly UserManager<AppUser> _userManager;

        public _AdminLayoutProfileSettingComponent(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name); 
            ViewBag.ımage=values.ImageUrl;
            return View(); 
        }
    }
}
