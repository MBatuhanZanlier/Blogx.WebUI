using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutNotificationComponentPartial:ViewComponent 
    {
        private readonly INotificationService _notificationService;

        public _LayoutNotificationComponentPartial(INotificationService notificationService)
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
