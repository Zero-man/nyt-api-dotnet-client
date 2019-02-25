using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class BookDetails
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

        [JsonProperty("primary_isbn13")]
        public string PrimaryIsbn13 { get; set; }

        [JsonProperty("primary_isbn10")]
        public string PrimaryIsbn10 { get; set; }
    }
}

