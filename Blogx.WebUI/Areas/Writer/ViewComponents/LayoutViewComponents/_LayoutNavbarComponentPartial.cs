using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial : ViewComponent
    {  
        private readonly UserManager<AppUser> _userManager;

		public _LayoutNavbarComponentPartial(UserManager<AppUser> userManager)
		{
			_userManager = userManager;
		}

		public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.ımage = users.ImageUrl; 
            ViewBag.namesurname=users.Name + " " +users.Surname.ToUpper();
            return View();

        }
    }
}
