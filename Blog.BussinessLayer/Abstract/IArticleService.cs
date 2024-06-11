using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.Abstract
{
    public interface IArticleService : IGenericService<Article>
    {
        public List<Article> TGetArticleWither();
        AppUser TGetWriterİnfoByWriterId(int id);
        public List<Article> TGetArticlesByWriter(int id);
        List<Article> GetLastFourPost();
        public Article TGetArticleByWriterAndCategori(int id);
        List<Article> TGetSearchBlogs(string search);
        List<Article> TGetAppuserandCategories();

    }
}
