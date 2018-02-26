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
        public async Task ShouldReturn500OnException()
        {
            Func<HttpRequestMessage, Task<HttpResponseMessage>> handler = request => { throw new Exception("hi"); };
            var statusCode = HttpStatusCode.InternalServerError;
            var response = await Transmission.Handler(handler, new HttpRequestMessage()); 
            Assert.Equal(statusCode, response.StatusCode);
        }
        private Func<HttpRequestMessage, Task<HttpResponseMessage>> Handler(HttpStatusCode statusCode) => (request) => Task.FromResult(new HttpResponseMessage() { StatusCode = statusCode });
    }
}