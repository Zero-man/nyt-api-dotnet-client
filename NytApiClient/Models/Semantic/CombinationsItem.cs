using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class CombinationsItem
    {
        [JsonProperty("combination_source_concept_id")]
        public int? CombinationSourceConceptId { get; set; }

        [JsonProperty("combination_source_concept_name")]
        public string CombinationSourceConceptName { get; set; }

        [JsonProperty("combination_source_concept_type")]
        public string CombinationSourceConceptType { get; set; }

        [JsonProperty("combination_target_concept_id")]
        public int? CombinationTargetConceptId { get; set; }

        [JsonProperty("combination_target_concept_name")]
        public string CombinationTargetConceptName { get; set; }

        [JsonProperty("combination_target_concept_type")]
        public string CombinationTargetConceptType { get; set; }

        [JsonProperty("combination_note")]
        public string CombinationNote { get; set; }
    }
}
