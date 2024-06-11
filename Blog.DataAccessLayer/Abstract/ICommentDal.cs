using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Abstract
{
   public interface ICommentDal:IGenericDal<Comment>
    {
        List<Comment> GetCommentsByArticleıd(int id); 
       List<Comment> GetCommentByArticleıdArticlandAppuser(int id);
    }
}
