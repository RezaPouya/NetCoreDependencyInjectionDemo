using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Configs
{
    public class AppConfig
    {
        public string ApplicationName { get; set; }
        public string GreetingMessage { get; set; }
        public string AllowedHosts { get; set; }
    }
}
