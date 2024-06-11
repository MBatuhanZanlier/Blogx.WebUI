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
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TDelete(int id)
        { 
            _messageDal.Delete(id);
        }

        public Message TGetbyId(int id)
        { 
            return _messageDal.GetbyId(id); 
        }

        public List<Message> TGetlistAll()
        { 
            return _messageDal.GetlistAll();
        }

        public List<Message> TGetMessageList(string mail)
        { 
            return _messageDal.GetMessageList(mail);
        }

        public List<Message> TGetSendMessageList(string mail)
        {
            return _messageDal.GetSendMessageList(mail);
        }

        public void TInsert(Message entity)
        {
            _messageDal.Insert(entity);
        }

        public void TUpdate(Message entity)
        { 
            _messageDal.Update(entity);
        }
    }
}
