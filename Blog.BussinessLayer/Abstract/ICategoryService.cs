using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BussinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<Category>
    {
        public int TGetCategoryCount();
    }
}
