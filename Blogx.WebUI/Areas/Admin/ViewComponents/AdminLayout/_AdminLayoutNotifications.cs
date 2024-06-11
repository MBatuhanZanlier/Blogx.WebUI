using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class _AdminLayoutNotifications:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
