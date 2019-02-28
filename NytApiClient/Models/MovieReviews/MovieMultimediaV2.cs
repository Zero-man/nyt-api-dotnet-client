using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieMultimediaV2
    {
        [JsonProperty("resource")]
        public MovieMultimediaResourceV2 Resource { get; set; }
    }
}
