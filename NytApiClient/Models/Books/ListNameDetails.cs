using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class ListNameDetails
    {
        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("list_name_encoded")]
        public string ListNameEncoded { get; set; }

        [JsonProperty("oldest_published_date")]
        public string OldestPublishedDate { get; set; }

        [JsonProperty("newest_published_date")]
        public string NewestPublishedDate { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }
    }
}

