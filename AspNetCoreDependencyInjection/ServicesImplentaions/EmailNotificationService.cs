using AspNetCoreDependencyInjection.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class EmailNotificationService : IEmailNotificationService
    {
        public void SendMessage(string msg, int userId)
        {
            Console.WriteLine($"The message '{msg}' is send to user '{userId}' via email ");
        }
    }
}
