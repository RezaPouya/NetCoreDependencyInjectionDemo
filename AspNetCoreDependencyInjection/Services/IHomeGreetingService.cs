using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Services
{
    public interface IHomeGreetingService 
    {
        [Obsolete("Prefer the GetRandomGreeting method defined in IGreetingService")]
        string GetRandomHomePageGreeting();
    }
}
