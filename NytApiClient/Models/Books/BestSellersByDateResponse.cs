using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BestSellersByDateResponse
    {
        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("bestsellers_date")]
        public string BestsellersDate { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("normal_list_ends_at")]
        public int? NormalListEndsAt { get; set; }

        [JsonProperty("updated")]
        public string Updated { get; set; }

        [JsonProperty("books")]
        public IEnumerable<Book> Books { get; set; }

        [JsonProperty("corrections")]
        public IEnumerable<object> Corrections { get; set; }
    }
}