﻿using System;
using System.Net.Http;

namespace libhoney_core
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    namespace libhoney_core
    {
        public static class HttpAdapter
        {
            private static readonly HttpClient Client = new HttpClient();

            public static async Task<HttpResponseMessage> RequestHandler(HttpRequestMessage request) => await Client.SendAsync(request);
        }
    }
}