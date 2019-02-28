using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieReviewsResponse
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    
        [JsonProperty("copyright")]
        public string Copyright { get; set; }
    
        [JsonProperty("num_results")]
        public int? NumResults { get; set; }

        [JsonProperty("has_more")]
        public bool HasMore { get; set; }
    
        [JsonProperty("results")]
        public IEnumerable<MovieReview> Results { get; set; }
    }
}
