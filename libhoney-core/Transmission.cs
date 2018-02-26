using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace libhoney_core
    {
        public static class Transmission { 

        private static HoneycombResponse MapHttpResponseToHoneycombResponse(HttpResponseMessage response) => new HoneycombResponse
        {
                StatusCode = ((HttpStatusCode) response.StatusCode)
        };
        public static async Task<HoneycombResponse> Handler(Func<HttpRequestMessage, Task<HttpResponseMessage>> requestHandler, HttpRequestMessage request) {
            try {
                var response = await requestHandler(request);
                return MapHttpResponseToHoneycombResponse(response);
            }
            catch(Exception ex) {
                return new HoneycombResponse() {
                    StatusCode = HttpStatusCode.InternalServerError
                };
            }
         }
    }
}
