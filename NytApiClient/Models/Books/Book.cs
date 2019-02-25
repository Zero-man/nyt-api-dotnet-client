using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class Book
    {
        [JsonProperty("list_name")]
        public string ListName { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("bestsellers_date")]
        public string BestsellersDate { get; set; }

        [JsonProperty("published_date")]
        public string PublishedDate { get; set; }

        [JsonProperty("rank")]
        public int? Rank { get; set; }

        [JsonProperty("rank_last_week")]
        public int? RankLastWeek { get; set; }

        [JsonProperty("weeks_on_list")]
        public int? WeeksOnList { get; set; }

        [JsonProperty("asterisk")]
        public int? Asterisk { get; set; }

        [JsonProperty("dagger")]
        public int? Dagger { get; set; }

        [JsonProperty("amazon_product_url")]
        public string AmazonProductUrl { get; set; }

        [JsonProperty("isbns")]
        public IEnumerable<Isbns> Isbns { get; set; }

        [JsonProperty("book_details")]
        public IEnumerable<BookDetails> BookDetails { get; set; }

        [JsonProperty("reviews")]
        public IEnumerable<Review> Reviews { get; set; }
    }
}

