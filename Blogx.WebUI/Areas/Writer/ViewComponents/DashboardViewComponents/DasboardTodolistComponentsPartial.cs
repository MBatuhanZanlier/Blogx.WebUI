using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Areas.Writer.ViewComponents.DashboardViewComponents
{
    public class DasboardTodolistComponentsPartial:ViewComponent
    { 
        public IViewComponentResult Invoke() { return View(); }

    }
}
