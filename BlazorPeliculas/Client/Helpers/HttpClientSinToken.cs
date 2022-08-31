using System.Net.Http;

namespace BlazorPeliculas.Client.Helpers
{
    public class HttpClientSinToken
    {
        public HttpClientSinToken(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        public HttpClient HttpClient { get; }
    }
}
