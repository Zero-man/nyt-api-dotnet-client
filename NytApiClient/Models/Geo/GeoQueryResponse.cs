using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class GeoQueryResponse
    {
        [JsonProperty("results")]
        public IEnumerable<GeoEvent> Results { get; set; }
    }
}
