using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class Isbns
    {
        [JsonProperty("isbn10")]
        public string Isbn10 { get; set; }

        [JsonProperty("isbn13")]
        public string Isbn13 { get; set; }
    }
}
