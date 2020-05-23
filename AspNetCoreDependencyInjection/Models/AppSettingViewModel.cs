using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDependencyInjection.Models
{
    public class AppSettingViewModel
    {
        public string ApplicationName { get; set; }
        public string GreetingMessage { get; set; }
        public string AllowedHosts { get; set; }
        public AppSettingLiteDbViewModel LiteDb { get; set; }
        public AppSettingUserOptionConfigViewModel UserOptions { get; set; }
    }

    public class AppSettingLiteDbViewModel
    {
        public string ConnectionString { get; set; }
    }

    public class AppSettingUserOptionConfigViewModel
    {
        public string UsersAvatarsFolder { get; set; }
        public string UserDefaultPhoto { get; set; }
        public AppSettingUserAvatarImageOptionsViewModel UserAvatarImageOptions { get; set; }
    }

    public class AppSettingUserAvatarImageOptionsViewModel
    {
        public int MaxHeight { get; set; }
        public int MaxWidth { get; set; }
    }
}
