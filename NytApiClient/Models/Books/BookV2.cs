using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BookV2
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("contributor")]
        public string Contributor { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("contributor_note")]
        public string ContributorNote { get; set; }

        [JsonProperty("price")]
        public int? Price { get; set; }

        [JsonProperty("age_group")]
        public string AgeGroup { get; set; }

        [JsonProperty("publisher")]
        public string Publisher { get; set; }

        [JsonProperty("isbns")]
        public IEnumerable<Isbns> Isbns { get; set; }

        [JsonProperty("ranks_history")]
        public IEnumerable<RanksHistory> RanksHistory { get; set; }

        [JsonProperty("reviews")]
        public IEnumerable<Review> Reviews { get; set; }
    }
}

