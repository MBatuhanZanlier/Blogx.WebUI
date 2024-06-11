using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutMessageComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager; 
        private readonly IMessageService _messageService;

        public _LayoutMessageComponentPartial(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string mail)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = user.Email;
            var messagelist = _messageService.TGetMessageList(mail);
           
            return View(messagelist);
        }
    }
}
