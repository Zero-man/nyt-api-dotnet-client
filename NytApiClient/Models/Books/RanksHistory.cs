using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class RanksHistory
    {
        [JsonProperty("primary_isbn10")]
        public string PrimaryIsbn10 { get; set; }

        [JsonProperty("primary_isbn13")]
        public string PrimaryIsbn13 { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("bestsellers_date")]
        public string BestsellersDate { get; set; }

        [JsonProperty("weeks_on_list")]
        public int? WeeksOnList { get; set; }

        [JsonProperty("ranks_last_week")]
        public object RanksLastWeek { get; set; }

        [JsonProperty("asterisk")]
        public int? Asterisk { get; set; }

        [JsonProperty("dagger")]
        public int? Dagger { get; set; }
    }
}
