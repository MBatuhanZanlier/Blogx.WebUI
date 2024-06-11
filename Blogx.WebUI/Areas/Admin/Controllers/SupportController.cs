using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class SupportController : Controller
    { 
        private readonly IMessageService _messageService;
        private readonly UserManager<AppUser> _userManager;

        public SupportController(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }


        public async Task<IActionResult> Index(string mail)
        {
            var usersmail = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = usersmail.Email;
            var recivermessagelist = _messageService.TGetMessageList(mail);
            return View(recivermessagelist);
         
        }
        public async Task<IActionResult> SendMessageList(string mail)
        {
            var usersmail = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = usersmail.Email;
            var sendmessage = _messageService.TGetSendMessageList(mail);
            return View(sendmessage);

        }
    }
}
