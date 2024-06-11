using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error(int code)
        {
            return View();
        }
    }
}
