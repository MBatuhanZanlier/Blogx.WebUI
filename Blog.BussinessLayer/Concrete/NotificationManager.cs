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
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TDelete(int id)
        { 
            _notificationDal.Delete(id);    
        }

        public Notification TGetbyId(int id)
        { 
            return _notificationDal.GetbyId(id);
        }

        public List<Notification> TGetlistAll()
        { 
            return _notificationDal.GetlistAll();
        }

        public void TInsert(Notification entity)
        { 
            _notificationDal.Insert(entity);
        }

        public void TUpdate(Notification entity)
        { 
            _notificationDal.Update(entity);
        }
    }
}
