using Blog.BussinessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailAddCommentComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _BlogDetailAddCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            Comment CMT =new Comment();
            CMT.ArticleId=id;
            return View(CMT);
        }


    }
}
