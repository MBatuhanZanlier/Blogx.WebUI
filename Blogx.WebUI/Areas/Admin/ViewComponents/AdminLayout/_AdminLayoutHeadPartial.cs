using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.ViewComponents.AdminLayout
{
    public class _AdminLayoutHeadPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }
    }
}
