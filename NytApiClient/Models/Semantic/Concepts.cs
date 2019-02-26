using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class Concepts {
        [JsonProperty("nytd_des")]
        public IEnumerable<string> NytdDes { get; set; }
    
        [JsonProperty("nytd_org")]
        public IEnumerable<string> NytdOrg { get; set; }
    
        [JsonProperty("nytd_per")]
        public IEnumerable<string> NytdPer { get; set; }
    }
}
