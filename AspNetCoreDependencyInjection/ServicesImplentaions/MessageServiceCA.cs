using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceCA : IMessageServiceC
    {
        public string Message()
        {
            return "A message from IMessageServiceC and MessageServiceCA";
        }
    }
}