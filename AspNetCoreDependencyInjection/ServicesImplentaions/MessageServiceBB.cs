using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceBB : IMessageServiceB
    {
        public string Message()
        {
            return "A message from IMessageServiceB and MessageServiceBB";
        }
    }
}