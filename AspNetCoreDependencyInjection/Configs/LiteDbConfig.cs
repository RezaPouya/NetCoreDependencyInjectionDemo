namespace AspNetCoreDependencyInjection.Configs
{
    public interface ILiteDbConfig
    {
        public string ConnectionString { get; set; }
    }

    public class LiteDbConfig : ILiteDbConfig
    {
        public string ConnectionString { get; set; }
    }
}