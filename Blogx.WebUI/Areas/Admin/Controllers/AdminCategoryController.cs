using Blog.BussinessLayer.Abstract;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Mvc;

//hata burdaydı hocam burada eski kullanılmayan bir using tanımı vardı ondan dolayı diyorki sistem bu projede tanımlı değil mesela
//sizin hatada buydu başka bir using kullanmaya çalışırken diyorki ben bunu bulamadım yanlış mı yazdınız diye aslında saçma bir hata 
//yani küçük ondan doalyı razor oluşturmuyor ama bir tecrübe oluyor insana bir daha error varken razor oluşturmazsınız :):) yani bende 
//öyle oldu 

//bir de şunuda göstereyim eğer kullanılmayan veya gereksiz duran usingler varsa sağ tıkta Remove and sort using sekmesi var onu kullanırsanız gereksizleri ve kullanılmayanları kaldırır
//meseela hata agitti

namespace Blogx.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]/{id?}")]
    public class AdminCategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public AdminCategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var values = _categoryService.TGetlistAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory() { return View(); }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TInsert(category);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {

            _categoryService.TDelete(id);
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TGetbyId(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _categoryService.TUpdate(category);
            return RedirectToAction("Index");
        }


    }
}
