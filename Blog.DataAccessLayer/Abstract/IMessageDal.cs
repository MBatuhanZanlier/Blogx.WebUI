using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.Abstract
{
  public interface IMessageDal:IGenericDal<Message> 
    {
        public List<Message> GetMessageList(string mail); 
        public List<Message> GetSendMessageList(string mail);
    }
}
