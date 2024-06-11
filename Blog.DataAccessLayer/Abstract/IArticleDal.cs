using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Abstract
{
  public interface IArticleDal:IGenericDal<Article>
    {
        List<Article> GetArticleWither();
        AppUser GetWriterİnfoByWriterId(int id); 
        List<Article> GetArticlesByWriter(int id);
        List<Article> GetLastFourPost(); 
        Article GetArticleByWriterAndCategori(int id);
        List<Article> GetSearchBlogs(string search);
        List<Article> GetAppuserandCategories(); 
    }
}
