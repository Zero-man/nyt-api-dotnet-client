using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class Concept
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

        [JsonProperty("taxonomy")]
        public IEnumerable<TaxonomyItem> Taxonomy { get; set; }

        [JsonProperty("links")]
        public IEnumerable<LinksItem> Links { get; set; }

        [JsonProperty("search_api_query")]
        public string SearchApiQuery { get; set; }

        [JsonProperty("article_list")]
        public ArticleList ArticleList { get; set; }

        [JsonProperty("scope_notes")]
        public IEnumerable<ScopeNotesItem> ScopeNotes { get; set; }

        [JsonProperty("combinations")]
        public IEnumerable<CombinationsItem> Combinations { get; set; }

        [JsonProperty("ancestors")]
        public IEnumerable<ConceptRelation> Ancestors { get; set; }

        [JsonProperty("descendants")]
        public IEnumerable<ConceptRelation> Descendants { get; set; }
    }
}
