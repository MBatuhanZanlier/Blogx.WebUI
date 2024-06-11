using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadComponentPartial:ViewComponent
    { 
        public  IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
