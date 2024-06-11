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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(int id)
        {
         _categoryDal.Delete(id); 
        }

        public Category TGetbyId(int id)
        { 
            return _categoryDal.GetbyId(id);
        }

        public int TGetCategoryCount()
        { 
            return _categoryDal.GetCategoryCount();
        }

        public List<Category> TGetlistAll()
        { 
            return _categoryDal.GetlistAll();
        }

        public void TInsert(Category entity)
        { 
             _categoryDal.Insert(entity);
        }

        public void TUpdate(Category entity)
        { 
            _categoryDal.Update(entity);    
        }
    }
}
