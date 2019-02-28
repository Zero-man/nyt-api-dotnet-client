using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieLink
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    
        [JsonProperty("url")]
        public string Url { get; set; }
    
        [JsonProperty("suggested_link_text")]
        public string SuggestedLinkText { get; set; }
    }
}
