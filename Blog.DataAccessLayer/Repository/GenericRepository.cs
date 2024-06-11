using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        BlogContext _context = new BlogContext();


        public void Delete(int id)
        {
            var values = _context.Set<T>().Find(id);
            _context.Set<T>().Remove(values);
            _context.SaveChanges();
        }

        public T GetbyId(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetlistAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            var values = _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var values = _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
