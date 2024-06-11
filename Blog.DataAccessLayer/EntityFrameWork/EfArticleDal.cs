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
	public class EfArticleDal : GenericRepository<Article>, IArticleDal
	{ 
		BlogContext context=new BlogContext();

        public List<Article> GetAppuserandCategories()
        {
            var values = context.Articles.Include(x => x.AppUser).Include(y => y.Category).ToList();
            return values;
        }

        public Article GetArticleByWriterAndCategori(int id)
        {
            var values=context.Articles.Where(x=>x.ArticleId==id).Include(x=>x.Category).Include(x=>x.AppUser).FirstOrDefault();
            return values;
        }

        public List<Article> GetArticlesByWriter(int id)
        { 
			var values=context.Articles.Where(x=>x.AppUserId==id).Include(y=>y.Category).ToList(); 
			return values;
        }

        public List<Article> GetArticleWither()
		{ 
			var values=context.Articles.Include(x=>x.AppUser).ToList(); 
			return values;
		}

        public List<Article> GetLastFourPost()
        { 
            var values=context.Articles.OrderByDescending(x=>x.CreatedDate).Take(4).ToList();
            return values;
        }

        public List<Article> GetSearchBlogs(string search)
        {
            var values = context.Articles.Where(x => x.Title.Contains(search)).Include(x => x.AppUser).ToList();
            return values;
        }

        public AppUser GetWriterİnfoByWriterId(int id)
        { 
			var values=context.Articles.Where(x=>x.ArticleId==id).Select(y=>y.AppUser).FirstOrDefault();
			return values;
        } 
    }
}
