    using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]

    public class MessageController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public MessageController(UserManager<AppUser> userManager, IMessageService messageService)
        {
            _userManager = userManager;
            _messageService = messageService;
        }


        public async Task<IActionResult> MessageList(string mail)
        {
            var usersmail = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = usersmail.Email;
            var recivermessagelist = _messageService.TGetMessageList(mail);
            return View(recivermessagelist);
        }
        [HttpGet]

        public async Task<IActionResult> SendMessageList(string mail)
        {
            var usersmail = await _userManager.FindByNameAsync(User.Identity.Name);
            mail = usersmail.Email;
            var sendmessage= _messageService.TGetSendMessageList(mail); 
            return View(sendmessage);
            
        }
       

        public IActionResult MessageDetail(int id)
        {
            var values=_messageService.TGetbyId(id); 
            return View(values);
        } 

        [HttpGet]

        public IActionResult SendMessage() { return View(); }



        [Route("SendMessage")]
        [HttpPost]
        public async Task <IActionResult> SendMessage(Message message)
        {
            var users = await _userManager.FindByNameAsync(User.Identity.Name);  
            message.SenderNameSurname= users.Name + " " +users.Surname.ToUpper();
            message.SenderMail = users.Email; 
            message.Date= DateTime.Now;  
            _messageService.TInsert(message);
            return RedirectToAction("SendMessageList");
        } 
        
        public IActionResult DeleteMessage(int id) 
        { 
              _messageService.TDelete(id);
            return RedirectToAction("MessageList");
        }

    }
}
