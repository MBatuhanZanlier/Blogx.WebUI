using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.DataAccessLayer.Repository;
using Blog.EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFrameWork
{
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    { 
        BlogContext context=new BlogContext();

        public List<Comment> GetCommentByArticleıdArticlandAppuser(int id)
        {
            var values = context.Comments.Where(x => x.ArticleId == id && x.Status == true).Include(y => y.AppUser).Include(y=>y.Article).ToList(); 
            return values;
        }

        public List<Comment> GetCommentsByArticleıd(int id)
        { 
            var values=context.Comments.Where(x=> x.ArticleId==id && x.Status == true).Include(y=>y.AppUser).ToList();
            return values;
        }
    }
}
