using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class List
    {
        [JsonProperty("list_id")]
        public int? ListId { get; set; }

        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("list_image")]
        public string ListImage { get; set; }

        [JsonProperty("books")]
        public IEnumerable<BookV3> Books { get; set; }
    }
}

