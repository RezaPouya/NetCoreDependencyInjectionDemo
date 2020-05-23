﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{
    public interface INotificationService
    {
        void SendMessage(string msg, int userId);
    }
}
