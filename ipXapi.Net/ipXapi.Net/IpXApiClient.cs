using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ipXapi.Net.Model;

namespace ipXapi.Net
{
    internal class IpXApiHttpClient:HttpClient
    {
        public IpXApiHttpClient(string apiKey,HttpMessageHandler handler=null, bool disposeHandler=false) : base(handler??new HttpClientHandler(), disposeHandler)
        {
            DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {apiKey}");
        }
    }
    
    
    public class IpXApiClient
    {
        private readonly string _apiKey;
        private HttpClient HttpClient { get; set; }
        public HttpClientHandler CustomHttpClientHandler
        {
            set => HttpClient = new IpXApiHttpClient(_apiKey,value);
        }
        public IpXApiClient(string apiKey)
        {
            _apiKey = apiKey;
            HttpClient = new IpXApiHttpClient(_apiKey);
        }

        public async Task<IpInfo> GetIpInfoAsync(string ip)
        {
            var httpResponseMessage = await HttpClient.GetAsync($"https://ipxapi.com/api/ip?ip={ip}");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<IpInfo>(content);
            }
            return null;
        }
    }
}