using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace Blogx.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class NotificationController : Controller
    {
        private readonly INotificationService _notificationService; 
        private readonly UserManager<AppUser> _userManager;

        public NotificationController(INotificationService notificationService, UserManager<AppUser> userManager)
        {
            _notificationService = notificationService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var values = _notificationService.TGetlistAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult SendNotification()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SendNotification(Notification notification)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            notification.NotificationsSenderName = values.Name; 
            notification.NotificationsSenderSurname= values.Surname;
            notification.NotificationDate = DateTime.Now;
            notification.NotificationImageUrl = "Abc";
            _notificationService.TInsert(notification);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNotifacation(int id) 
        { 
             _notificationService.TDelete(id);
            return RedirectToAction("Index");
        }
    }
}
