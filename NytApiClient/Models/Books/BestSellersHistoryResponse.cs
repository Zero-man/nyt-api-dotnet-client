using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BestSellersHistoryResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("num_results")]
        public int? NumResults { get; set; }

        [JsonProperty("results")]
        public IEnumerable<BookV2> Results { get; set; }
    }
}