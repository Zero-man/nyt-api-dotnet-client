using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieMultimedia
    {
        [JsonProperty("resource")]
        public MovieMultimediaResource Resource { get; set; }
    }
}
