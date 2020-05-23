using System;

namespace AspNetCoreDependencyInjection.Models
{
    public class HomeViewModel
    {
        public string Id { get; set; }
        public string Message { get; set; }
        public DateTime DateTime { get; set; }


        public string GreetingMessage { get; set; }
    }

}