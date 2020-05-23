using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceCB : IMessageServiceC
    {
        public string Message()
        {
            return "A message from IMessageServiceC and MessageServiceCB";
        }
    }
}