using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BestSellersListNamesResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int? NumResults { get; set; }

        [JsonProperty("results")]
        public IEnumerable<ListNameDetails> Results { get; set; }
    }
}