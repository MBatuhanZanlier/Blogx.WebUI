using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityLayer
{
    public class Tag
    {

        public int TagId { get; set; }
        public string TagTitle { get; set; }
    }
}
