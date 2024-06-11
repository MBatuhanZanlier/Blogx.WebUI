using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityLayer
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string? CategoryName { get; set; } 
        public List<Article> Articles { get; set; }
    }
}
