using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using libhoney_core.libhoney_core;
using Xunit;

namespace test_libhoney_core
{
    public class HttpAdapterTests
    {
        [Fact]
        public async Task Test1Async()
        {
            // var statusCode = HttpStatusCode.Accepted;
            // var response = await HttpAdapter.Send(RequestHandler(statusCode), ResponseHandler(), new HttpRequestMessage()); 
            // Assert.Equal(statusCode, response.StatusCode);
        }

        private Func<HttpRequestMessage, Task<HttpResponseMessage>> RequestHandler(HttpStatusCode statusCode) => (request) => Task.FromResult(new HttpResponseMessage() { StatusCode = statusCode });
    }
}
