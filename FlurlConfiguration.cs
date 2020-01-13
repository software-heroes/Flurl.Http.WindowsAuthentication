namespace Flurl.Http.WindowsAuthentication
{
    public static class FlurlConfiguration
    {
        public static void ConfigureDomainWithWindowsAuthentication(string url)
        {
            FlurlHttp.ConfigureClient(url, cli =>
                cli.Settings.HttpClientFactory = new UseDefaultCredentialsClientFactory());
        }

        public static void ConfigureAllRequestsWithWindowsAuthentication()
        {
            FlurlHttp.Configure(settings => settings.HttpClientFactory = new UseDefaultCredentialsClientFactory());
        }
    }
}