using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]/{id?}")]

    public class DashboardController : Controller
    {
   
        public IActionResult Index()
        {

            return View();
        }
    }
}
