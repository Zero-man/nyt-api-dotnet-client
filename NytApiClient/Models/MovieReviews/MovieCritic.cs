using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieCritic
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }
    
        [JsonProperty("sort_name")]
        public string SortName { get; set; }
    
        [JsonProperty("status")]
        public string Status { get; set; }
    
        [JsonProperty("bio")]
        public string Bio { get; set; }
    
        [JsonProperty("seo_name")]
        public string SeoName { get; set; }
    
        [JsonProperty("multimedia")]
        public MovieMultimediaV2 Multimedia { get; set; }
    }
}
