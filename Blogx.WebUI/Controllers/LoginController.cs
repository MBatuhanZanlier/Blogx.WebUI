using Blog.EntityLayer;
using Blogx.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel model)
        {
            if(model.UsurName !=null && model.Password !=null)
            {
                var result=await _signInManager.PasswordSignInAsync(model.UsurName,model.Password ,false,true); 
                if(result.Succeeded) 
                {
                    return RedirectToAction("MyBlogList", "Blog", new { area = "Writer" });

                }
                else
                {
                    ModelState.AddModelError("", "kullanıcı adı veya şifre hatalı");
                }
            } 
            else
            {
                ModelState.AddModelError("", "Lütfen Alanları boş geçmeyiniz");
            }
          return View();
        }
    }
}
