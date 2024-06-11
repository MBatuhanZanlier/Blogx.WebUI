using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/AdminLayout")]
    public class AdminLayoutController : Controller
    {
         [Route("AdminPageLayout")]
        public IActionResult AdminPageLayout()
        {
            return View();
        }

    }
}
