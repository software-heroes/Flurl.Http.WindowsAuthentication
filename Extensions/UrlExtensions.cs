namespace Flurl.Http.WindowsAuthentication
{
    public static class UrlExtensions
    {
        public static IFlurlRequest WithWindowsAuth(this Url url) => new FlurlRequest(url).WithWindowsAuth();
    }
}
