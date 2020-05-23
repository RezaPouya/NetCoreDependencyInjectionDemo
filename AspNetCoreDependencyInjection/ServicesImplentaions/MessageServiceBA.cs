using AspNetCoreDependencyInjection.Services;

namespace AspNetCoreDependencyInjection.ServicesImplentaions
{
    public class MessageServiceBA : IMessageServiceB
    {
        public string Message()
        {
            return "A message from IMessageServiceB and MessageServiceBA";
        }
    }
}