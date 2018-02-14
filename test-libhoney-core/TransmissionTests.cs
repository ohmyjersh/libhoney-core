using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using libhoney_core;
using Xunit;

namespace test_libhoney_core
{
    public class TransmissionTests
    {
        [Fact]
        public async Task TestSend()
        {
            // var statusCode = HttpStatusCode.Accepted;
            // var response = await new Transmission().Send(RequestHandler(statusCode), ResponseHandler(), new HttpRequestMessage()); 
            // Assert.Equal(statusCode, response.StatusCode);
        }

        private Func<HttpResponseMessage, HoneycombResponse> ResponseHandler()
        {
            throw new NotImplementedException();
        }

        private Func<HttpRequestMessage, Task<HttpResponseMessage>> RequestHandler(HttpStatusCode statusCode) => (request) => Task.FromResult(new HttpResponseMessage() { StatusCode = statusCode });
    }
}