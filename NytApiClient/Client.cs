using System;
using System.Collections.Generic;
using System.Linq;
using RestEase;

namespace NytApiClient
{
    public class Client
    { 
        public static T For<T>(NytApiClientOptions options)
        {
            return new RestClient(options.BaseUrl).For<T>();
        }

        public static T For<T>()
        {
            return new RestClient("https://api.nytimes.com").For<T>();
        }
    }
}
