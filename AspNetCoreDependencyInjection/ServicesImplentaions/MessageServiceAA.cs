using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceAA : IMessageServiceA
    {
        public string Message()
        {
            return "A message from IMessageServiceA and MessageServiceAA";
        }
    }
}