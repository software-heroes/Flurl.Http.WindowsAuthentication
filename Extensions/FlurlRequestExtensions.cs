using System.Net.Http;

namespace Flurl.Http.WindowsAuthentication
{
    public static class FlurlRequestExtensions
    {
        public static IFlurlRequest WithWindowsAuth(this IFlurlRequest flurlRequest)
        {
            ((HttpClientHandler) flurlRequest.Client.HttpMessageHandler).UseDefaultCredentials = true;
            return flurlRequest;
        }           
    }
}
