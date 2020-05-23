using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceAB : IMessageServiceA
    {
        public string Message()
        {
            return "A message from IMessageServiceA and MessageServiceAB";
        }
    }
}