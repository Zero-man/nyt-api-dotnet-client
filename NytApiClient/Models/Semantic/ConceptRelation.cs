using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class ConceptRelation
    {
        [JsonProperty("concept_id")]
        public int? ConceptId { get; set; }

        [JsonProperty("concept_name")]
        public string ConceptName { get; set; }

        [JsonProperty("is_times_tag")]
        public int? IsTimesTag { get; set; }

        [JsonProperty("concept_status")]
        public string ConceptStatus { get; set; }

        [JsonProperty("vernacular")]
        public string Vernacular { get; set; }

        [JsonProperty("concept_type")]
        public string ConceptType { get; set; }

        [JsonProperty("concept_created")]
        public string ConceptCreated { get; set; }

        [JsonProperty("concept_updated")]
        public string ConceptUpdated { get; set; }
    }
}
