using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace libhoney_core
{
    public static class HttpAdapter
    {
        private static readonly HttpClient Client = new HttpClient();

        public static HttpRequestMessage GenerateRequestMessage(string json) => new HttpRequestMessage();

        public static async Task<HttpResponseMessage> Send(HttpRequestMessage request) => await Client.SendAsync(request);
    }
}
