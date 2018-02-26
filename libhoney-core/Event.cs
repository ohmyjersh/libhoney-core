using System;
using libhoney_core;

namespace libhoney_core
{
    public class Event {
        public string Hello {get; set;}
        public void Send() {
            Honeycomb.Send(this);
        }
    }
}

    internal class User {
        public void Hello() {
            Honeycomb.Send(new Event() {Hello = "hi"} );
        }
    }

    internal class Honeycomb : HoneycombBase
    {
        string _apihost = "https://api.honeycomb.io";
        public Honeycomb(string teamWriteKey, string dataSetName, string apiHost = "https://api.honeycomb.io",  ) {
            
        }
        internal static void Send(Event thing)
        {
            throw new NotImplementedException();
        }
    }