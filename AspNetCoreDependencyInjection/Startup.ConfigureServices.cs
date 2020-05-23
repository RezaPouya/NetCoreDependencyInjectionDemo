using AspNetCoreDependencyInjection.Configs;
using AspNetCoreDependencyInjection.Extensions;
using AspNetCoreDependencyInjection.Helpers;
using AspNetCoreDependencyInjection.Services;
using AspNetCoreDependencyInjection.ServicesImplentaions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

namespace AspNetCoreDependencyInjection
{
    public partial class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddTransient<IMessageServiceA, MessageServiceAA>();

            services.AddScoped<IMessageServiceB, MessageServiceBA>();
            services.TryAddScoped<IMessageServiceB, MessageServiceBB>();

            var serviceDescriptor1 = new ServiceDescriptor(typeof(IMessageServiceB),
                typeof(MessageServiceBB),
                ServiceLifetime.Scoped);

            var serviceDescriptor2 = ServiceDescriptor.Describe(typeof(IMessageServiceB),
                typeof(MessageServiceBB),
                ServiceLifetime.Scoped);

            var serviceDescriptor3 = ServiceDescriptor.Singleton(typeof(IMessageServiceB), typeof(MessageServiceBB));

            var serviceDescriptor4 = ServiceDescriptor.Singleton<IMessageServiceB, MessageServiceBB>();

            services.Add(serviceDescriptor1);

            services.Replace(serviceDescriptor3);

            services.RemoveAll<IMessageServiceB>();

            services.AddScoped<IAppointmentRegisterationRule, AppointmentRegisterationRule1>();
            services.AddScoped<IAppointmentRegisterationRule, AppointmentRegisterationRule2>();
            services.AddScoped<IAppointmentRegisterationRule, AppointmentRegisterationRule3>();
            services.AddScoped<IAppointmentRegisterationRule, AppointmentRegisterationRule4>();
            services.AddScoped<IAppointmentRegisterationRule, AppointmentRegisterationRule3>();

            services.TryAddEnumerable(new[] {
                ServiceDescriptor.Scoped(typeof(IAppointmentRegisterationRule), typeof(AppointmentRegisterationRule1)),
                ServiceDescriptor.Scoped(typeof(IAppointmentRegisterationRule), typeof(AppointmentRegisterationRule2)),
                ServiceDescriptor.Scoped(typeof(IAppointmentRegisterationRule), typeof(AppointmentRegisterationRule3)),
                ServiceDescriptor.Scoped(typeof(IAppointmentRegisterationRule), typeof(AppointmentRegisterationRule4)),
            });

            services.AddSingleton<ILiteDbConfig>(sp => sp.GetRequiredService<IOptionsMonitor<LiteDbConfig>>().CurrentValue);

            services.AddScoped<IEmailNotificationService, EmailNotificationService>();
            services.AddScoped<ISMSNotificationService, SMSNotificationService>();

            services.AddSingleton<INotificationService>(sp => new CompositeNotificationService(
                new INotificationService[] {
                    sp.GetRequiredService<IEmailNotificationService>() ,
                    sp.GetRequiredService<ISMSNotificationService>()
                }
            ));

            services.AddTransient<IAccountBuilder, AccountBuilder>();

            services.AddScoped<IAccount>(sp =>
            {
                var builder = sp.GetService<IAccountBuilder>();
                builder.WithAccountType(AccountType.Guest);
                return builder.Build();
            });

            services.TryAddSingleton<GreetingService>();
            services.TryAddSingleton<IHomeGreetingService>(sp => sp.GetRequiredService<GreetingService>());
            services.TryAddSingleton<IGreetingService>(sp => sp.GetRequiredService<GreetingService>());

            services.AddScoped(services => new GuidProvider());
            services.RegisterConfiguration(this.Configuration);
            services.OpenGenericRegisterationExample();
        }
    }
}