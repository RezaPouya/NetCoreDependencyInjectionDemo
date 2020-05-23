namespace AspNetCoreDependencyInjection.Configs
{
    public class UserOptionConfig
    {
        public string UsersAvatarsFolder { get; set; }
        public string UserDefaultPhoto { get; set; }
        public UserAvatarImageOptions UserAvatarImageOptions { get; set; }
    }

    public class UserAvatarImageOptions
    {
        public int MaxHeight { get; set; }
        public int MaxWidth { get; set; }
    }
}