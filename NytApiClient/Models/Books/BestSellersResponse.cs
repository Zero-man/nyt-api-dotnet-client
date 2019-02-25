using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BestSellersResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int? NumResults { get; set; }

        [JsonProperty("last_modified")]
        public string LastModified { get; set; }

        [JsonProperty("results")]
        public IEnumerable<Book> Results { get; set; }
    }
}