using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AspNetCoreDependencyInjection
{
    public partial class Startup
    {
        public IWebHostEnvironment Environment { get; }
        public IConfiguration Configuration { get; }
        public IServiceCollection Services { get; set; }

        public Startup(IWebHostEnvironment environment)
        {

            var appSettingsFile = environment.IsProduction() ? "appsettings.json" : "appsettings-dev.json";
            var builder = new ConfigurationBuilder()
                .SetBasePath(environment.ContentRootPath)
                .AddJsonFile( appSettingsFile , optional: true)
                .AddEnvironmentVariables();

            this.Environment = environment;
            this.Configuration = builder.Build();
        }
    }
}