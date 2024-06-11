using Blog.BussinessLayer.Abstract;
using Blog.DataAccessLayer.Abstract;
using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IArticleDal _articleDal;

        public ArticleManager(IArticleDal articleDal)
        {
            _articleDal = articleDal;
        }

        public AppUser TGetWriterİnfoByWriterId(int id)
        {
            return _articleDal.GetWriterİnfoByWriterId(id);
        }

        public void TDelete(int id)
        {

            _articleDal.Delete(id);

        }

        public List<Article> TGetArticleWither()
        {
            return _articleDal.GetArticleWither();
        }

        public Article TGetbyId(int id)
        {
            return _articleDal.GetbyId(id);
        }

        public List<Article> TGetlistAll()
        {
            return _articleDal.GetlistAll();
        }

        public void TInsert(Article entity)
        {

            _articleDal.Insert(entity);


        }

        public void TUpdate(Article entity)
        {
            _articleDal.Update(entity);
        }

        public List<Article> TGetArticlesByWriter(int id)
        {
            return _articleDal.GetArticlesByWriter(id);
        }

        public List<Article> GetLastFourPost()
        {
            return _articleDal.GetLastFourPost();
        }

        public Article TGetArticleByWriterAndCategori(int id)
        {
            return _articleDal.GetArticleByWriterAndCategori(id);
        }

        public List<Article> TGetSearchBlogs(string search)
        {
            return _articleDal.GetSearchBlogs(search);
        }

        public List<Article> TGetAppuserandCategories()
        {
           return _articleDal.GetAppuserandCategories();  
        }
    }
}
