namespace Flurl.Http.WindowsAuthentication
{
    using System.Net.Http;
    using Flurl.Http.Configuration;

    public class UseDefaultCredentialsClientFactory : DefaultHttpClientFactory
    {
        public override HttpMessageHandler CreateMessageHandler()
        {
            return new HttpClientHandler 
            { 
                UseDefaultCredentials = true 
            };
        }
    }
}