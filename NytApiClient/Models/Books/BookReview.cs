using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BookReview
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("publication_dt")]
        public string PublicationDate { get; set; }

        [JsonProperty("byline")]
        public string Byline { get; set; }

        [JsonProperty("book_title")]
        public string BookTitle { get; set; }

        [JsonProperty("book_author")]
        public string BookAuthor { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }

        [JsonProperty("isbn13")]
        public IEnumerable<string> Isbn13 { get; set; }

    }
}