using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using libhoney_core.libhoney_core;

namespace libhoney_core
    {
        public class Transmission { 
        private static HoneycombResponse ResponseHandler(HttpResponseMessage response) => MapHttpResponseToHoneycombResponse(response);
            private static HoneycombResponse MapHttpResponseToHoneycombResponse(HttpResponseMessage response) => new HoneycombResponse
            {
                StatusCode = (HttpStatusCode) response.StatusCode,
            };
        public static async Task<HoneycombResponse> Send(Func<HttpRequestMessage, Task<HttpResponseMessage>> requestHandler, 
            Func<HttpResponseMessage, HoneycombResponse> responseHandler, HttpRequestMessage request) {
            try {
                var response = await requestHandler(request);
                return responseHandler(response);
            }
            catch(Exception) {
                return new HoneycombResponse();
            }
         }
    }
}
