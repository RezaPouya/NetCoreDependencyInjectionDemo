using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceAC : IMessageServiceA
    {
        public string Message()
        {
            return "A message from IMessageServiceA and MessageServiceAC";
        }
    }
}