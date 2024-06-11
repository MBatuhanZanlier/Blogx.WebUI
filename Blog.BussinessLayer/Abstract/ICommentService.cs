using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.Abstract
{
   public interface ICommentService:IGenericService<Comment>
    {
        public List<Comment> TGetCommentByArticleıdArticlandAppuser(int id);
        public List<Comment> TGetCommentsByArticleıd(int id);
    }
}
