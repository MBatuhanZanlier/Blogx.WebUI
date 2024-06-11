using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.Dashboard
{
    public class DashboardHeadComponent:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}
