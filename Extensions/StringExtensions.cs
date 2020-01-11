namespace Flurl.Http.WindowsAuthentication
{
    public static class StringExtensions
    {
        public static IFlurlRequest WithWindowsAuth(this string url) => new FlurlRequest(url).WithWindowsAuth();
    }
}
