using Blog.DataAccessLayer.Abstract;
using Blog.DataAccessLayer.Repository;
using Blog.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccessLayer.EntityFrameWork
{
  public class EfNotificationDal:GenericRepository<Notification>,INotificationDal
    {
    }
}
