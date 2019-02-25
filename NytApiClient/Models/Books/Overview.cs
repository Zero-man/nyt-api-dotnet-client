using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class Overview
    {
        [JsonProperty("bestsellers_date")]
        public string BestsellersDate { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("lists")]
        public IEnumerable<List> Lists { get; set; }
    }
}
