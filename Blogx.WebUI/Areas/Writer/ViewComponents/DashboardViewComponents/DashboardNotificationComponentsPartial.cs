using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{
    public class DashboardNotificationComponentsPartial : ViewComponent
    { 
        private readonly INotificationService _notificationService;

        public DashboardNotificationComponentsPartial(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _notificationService.TGetlistAll();
            return View(values); 
        }
    }
}
