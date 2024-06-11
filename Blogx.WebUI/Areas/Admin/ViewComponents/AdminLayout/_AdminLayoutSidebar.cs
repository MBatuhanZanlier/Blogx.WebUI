using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class _AdminLayoutSidebar:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}
