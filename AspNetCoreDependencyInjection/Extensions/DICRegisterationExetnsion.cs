using AspNetCoreDependencyInjection.Configs;
using AspNetCoreDependencyInjection.Controllers;
using AspNetCoreDependencyInjection.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace AspNetCoreDependencyInjection.Extensions
{
    public static class DICRegisterationExetnsion
    {
        /// <summary>
        /// مثال ثبت برای اپن جنریت
        /// </summary>
        /// <param name="services"></param>
        public static void OpenGenericRegisterationExample(this IServiceCollection services)
        {
            services.TryAddScoped<ILogger<HomeController>, Logger<HomeController>>();
            services.TryAddScoped(typeof(ILogger<>), typeof(Logger<>));
        }


        /// <summary>
        /// ثبت تنظیمات به روش های مختلف 
        /// </summary>
        public static void RegisterConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(services => new AppConfig
            {
                ApplicationName = configuration["ApplicationName"],
                GreetingMessage = configuration["GreetingMessage"],
                AllowedHosts = configuration["AllowedHosts"]
            });

            services.AddSingleton(services => new AccountTypeBalanceConfig(
                    new List<(AccountType, long)> {
                        (AccountType.Guest , Convert.ToInt64 (configuration["AccountInitialBalance.Guest"]) ) ,
                        (AccountType.Silver , Convert.ToInt64 (configuration["AccountInitialBalance.Silver"]) ) ,
                        (AccountType.Gold , Convert.ToInt64 (configuration["AccountInitialBalance.Gold"]) ) ,
                        (AccountType.Platinum , Convert.ToInt64 (configuration["AccountInitialBalance.Platinum"]) ) ,
                        (AccountType.Titanium , Convert.ToInt64 (configuration["AccountInitialBalance.Titanium"]) ) ,
                    })
            );

            services.AddSingleton(services => new LiteDbConfig
            {
                ConnectionString = configuration["LiteDbConfig:ConnectionString"],
            });

            services.Configure<UserOptionConfig>(configuration.GetSection("UserOptionConfig"));
        }
    }
}