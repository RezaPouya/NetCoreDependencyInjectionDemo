using AspNetCoreDependencyInjection.Configs;
using AspNetCoreDependencyInjection.Helpers;
using AspNetCoreDependencyInjection.Models;
using AspNetCoreDependencyInjection.Services;
using AspNetCoreDependencyInjection.ServicesImplentaions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Controllers
{
    public class AppSettingsController : Controller
    {
        private readonly LiteDbConfig _liteDbConfig;
        private readonly AppConfig _appConfig;
        private readonly UserOptionConfig _userOptionConfig; 

        public AppSettingsController(AppConfig appConfig ,
            LiteDbConfig liteDbConfig ,
            IOptionsMonitor<UserOptionConfig> userOptionConfig)
        {
            _appConfig = appConfig;
            _liteDbConfig = liteDbConfig;
            _userOptionConfig = userOptionConfig.CurrentValue;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = new AppSettingViewModel
            {
                ApplicationName = _appConfig.ApplicationName,
                GreetingMessage = _appConfig.GreetingMessage,
                AllowedHosts = _appConfig.AllowedHosts,
                LiteDb = new AppSettingLiteDbViewModel
                {
                    ConnectionString = _liteDbConfig.ConnectionString
                },
                UserOptions = new AppSettingUserOptionConfigViewModel
                {
                    UserAvatarImageOptions = new AppSettingUserAvatarImageOptionsViewModel
                    {
                        MaxHeight = _userOptionConfig.UserAvatarImageOptions.MaxHeight,
                        MaxWidth = _userOptionConfig.UserAvatarImageOptions.MaxWidth,
                    },
                    UserDefaultPhoto = _userOptionConfig.UserDefaultPhoto,
                    UsersAvatarsFolder = _userOptionConfig.UsersAvatarsFolder
                }
            };

            return View(model);
        }
    }
}
