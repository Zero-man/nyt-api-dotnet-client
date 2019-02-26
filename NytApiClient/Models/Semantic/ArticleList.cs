using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class ArticleList
    {
        [JsonProperty("results")]
        public IEnumerable<ArticleListItem> Results { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }
    }
}
