using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.Blog
{
    public class _ScriptComponentPartial:ViewComponent
    { 
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
