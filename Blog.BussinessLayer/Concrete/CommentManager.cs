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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> TGetCommentsByArticleıd(int id)
        {
            return _commentDal.GetCommentsByArticleıd(id);
        }

        public void TDelete(int id)
        {
          _commentDal.Delete(id);
        }

        public Comment TGetbyId(int id)
        {
            return _commentDal.GetbyId(id);
        }

        public List<Comment> TGetlistAll()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Comment entity)
        {
            _commentDal.Insert(entity);

        }

        public void TUpdate(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetCommentByArticleıdArticlandAppuser(int id)
        {
           return _commentDal.GetCommentByArticleıdArticlandAppuser(id);
        }
    }
}
