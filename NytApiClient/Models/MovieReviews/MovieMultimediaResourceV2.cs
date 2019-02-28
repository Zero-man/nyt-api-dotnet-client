using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieMultimediaResourceV2
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    
        [JsonProperty("src")]
        public string Src { get; set; }
    
        [JsonProperty("height")]
        public int? Height { get; set; }
    
        [JsonProperty("width")]
        public int? Width { get; set; }
    
        [JsonProperty("credit")]
        public string Credit { get; set; }
    }
}
