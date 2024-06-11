using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Concrete;
using Blog.DataAccessLayer.Repository;
using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFrameWork
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        private readonly BlogContext _context;

        public EfMessageDal(BlogContext context)
        {
            _context = context;
        }

        public List<Message> GetMessageList(string mail)
        {
           var values=_context.Messages.Where(x=>x.ReceiverMail== mail).OrderByDescending(y=>y.Date).ToList(); 

        return values;
        }

        public List<Message> GetSendMessageList(string mail)
        {
           var values=_context.Messages.Where(x=>x.SenderMail==mail).OrderByDescending(y=>y.Date).ToList(); 
            return values;
        }
    }
}
