using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class MovieReview
    {
        [JsonProperty("display_title")]
        public string DisplayTitle { get; set; }
    
        [JsonProperty("mpaa_rating")]
        public string MpaaRating { get; set; }
    
        [JsonProperty("critics_pick")]
        public int? CriticsPick { get; set; }
    
        [JsonProperty("byline")]
        public string Byline { get; set; }
    
        [JsonProperty("headline")]
        public string Headline { get; set; }
    
        [JsonProperty("summary_short")]
        public string SummaryShort { get; set; }
    
        [JsonProperty("publication_date")]
        public string PublicationDate { get; set; }
    
        [JsonProperty("opening_date")]
        public string OpeningDate { get; set; }
    
        [JsonProperty("date_updated")]
        public string DateUpdated { get; set; }
    
        [JsonProperty("link")]
        public MovieLink Link { get; set; }
    
        [JsonProperty("multimedia")]
        public MovieMultimedia Multimedia { get; set; }
    }
}
