using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]


    public class SupportController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IMessageService _messageService;

        public SupportController(IMessageService messageService, UserManager<AppUser> userManager)
        {
            _messageService = messageService;
            _userManager = userManager;
        }

        [HttpGet]
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [Route("Index")]
        public async Task<IActionResult> Index(Message message)
        {
            var users = await _userManager.FindByNameAsync(User.Identity.Name);
            message.SenderNameSurname = users.Name + " " + users.Surname.ToUpper();
            message.SenderMail = users.Email;
            message.ReceiverNameSurname = "Admin";
            message.ReceiverMail = "admin@gmail.com";
            message.Date = DateTime.Now;
            _messageService.TInsert(message);
            return RedirectToAction("Index");
        }

    }
}
