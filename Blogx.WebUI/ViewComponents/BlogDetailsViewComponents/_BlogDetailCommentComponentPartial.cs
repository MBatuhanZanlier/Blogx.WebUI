using Blog.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogx.WebUI.ViewComponents.BlogDetailsViewComponents
{
    public class _BlogDetailCommentComponentPartial : ViewComponent
    {
        private readonly ICommentService _commentService;

        public _BlogDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetCommentsByArticleıd(id);
            return View(values);
        }
    }
}
