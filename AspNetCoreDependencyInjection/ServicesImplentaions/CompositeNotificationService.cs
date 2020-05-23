using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class CompositeNotificationService : INotificationService
    {
        private readonly IEnumerable<INotificationService> _notificationServices;

        public CompositeNotificationService(IEnumerable<INotificationService> notificationServices)
        {
            _notificationServices = notificationServices;
        }

        public void SendMessage(string msg, int userId)
        {
            foreach (var notificationServicei in _notificationServices) 
            {
                notificationServicei.SendMessage(msg, userId);
            }
        }
    }
}
