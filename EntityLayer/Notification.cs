using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.EntityLayer
{
    public class Notification
    {
        public int NotificationId { get; set; } 
        public string NotificationsSenderName { get; set; }
        public string NotificationsSenderSurname { get; set; }
        public string NotificationTitle { get; set; }
        public string NotificationDescription { get; set; } 
        public string NotificationImageUrl { get; set; }
        public DateTime NotificationDate { get; set; }

    }
}
