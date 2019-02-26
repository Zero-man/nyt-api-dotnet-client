using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class TaxonomyItem
    {
        [JsonProperty("source_concept_id")]
        public int? SourceConceptId { get; set; }

        [JsonProperty("target_concept_id")]
        public int? TargetConceptId { get; set; }

        [JsonProperty("source_concept_name")]
        public string SourceConceptName { get; set; }

        [JsonProperty("target_concept_name")]
        public string TargetConceptName { get; set; }

        [JsonProperty("source_concept_type")]
        public string SourceConceptType { get; set; }

        [JsonProperty("target_concept_type")]
        public string TargetConceptType { get; set; }

        [JsonProperty("source_concept_vernacular")]
        public string SourceConceptVernacular { get; set; }

        [JsonProperty("target_concept_vernacular")]
        public string TargetConceptVernacular { get; set; }

        [JsonProperty("taxonomic_relation")]
        public string TaxonomicRelation { get; set; }

        [JsonProperty("taxonomic_verification_status")]
        public string TaxonomicVerificationStatus { get; set; }
    }
}
