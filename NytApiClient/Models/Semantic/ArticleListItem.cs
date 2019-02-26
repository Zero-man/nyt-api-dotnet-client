using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class ArticleListItem
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("byline")]
        public string Byline { get; set; }

        [JsonProperty("concepts")]
        public Concepts Concepts { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("document_type")]
        public string DocumentType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("type_of_material")]
        public string TypeOfMaterial { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}







