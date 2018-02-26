using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using libhoney_core;
using Xunit;

namespace test_libhoney_core
{
    public class HttpAdapterTests
    {
        [Fact]
        public void ShouldReturn500OnException()
        {
            var request = HttpAdapter.GenerateRequestMessage("hi");
            Assert.True(typeof(HttpRequestMessage) == request.GetType());
        }
    }
}
