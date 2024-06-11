using Blog.BussinessLayer.Abstract;
using Blog.BussinessLayer.Concrete;
using Blog.DataAccessLayer.Concrete;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{    
    
    public class DashboardAppuserListComponentPartial:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public DashboardAppuserListComponentPartial(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string mail)
        {
            var users = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = users.Email;
            var messageList = _messageService.TGetMessageList(mail);
            return View(messageList);


        }
    }
}
