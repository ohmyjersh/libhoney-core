namespace libhoney_core
{
    using System;
    using System.Net;

    namespace libhoney_core
    {
        public class HoneycombResponse {
        public HttpStatusCode StatusCode { get; internal set; }
        public TimeSpan Duration { get; internal set; }
        public object Metadata { get; internal set; }
        public string Body { get; internal set; }
        public string ErrorMessage { get; internal set;
        }
    
    }
}
 
}
