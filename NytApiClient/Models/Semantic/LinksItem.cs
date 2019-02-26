using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class LinksItem
    {
        [JsonProperty("concept_id")]
        public int? ConceptId { get; set; }

        [JsonProperty("concept_name")]
        public string ConceptName { get; set; }

        [JsonProperty("is_times_tag")]
        public int? IsTimesTag { get; set; }

        [JsonProperty("concept_status")]
        public string ConceptStatus { get; set; }

        [JsonProperty("concept_type")]
        public string ConceptType { get; set; }

        [JsonProperty("link_id")]
        public int? LinkId { get; set; }

        [JsonProperty("relation")]
        public string Relation { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("link_type")]
        public string LinkType { get; set; }

        [JsonProperty("mapping_type")]
        public string MappingType { get; set; }
    }
}







