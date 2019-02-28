using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class GeoEvent
    {
        [JsonProperty("event_id")]
        public int? EventId { get; set; }
    
        [JsonProperty("event_schedule_id")]
        public int? EventScheduleId { get; set; }
    
        [JsonProperty("last_modified")]
        public string LastModified { get; set; }
    
        [JsonProperty("event_name")]
        public string EventName { get; set; }
    
        [JsonProperty("event_detail_url")]
        public string EventDetailUrl { get; set; }
    
        [JsonProperty("web_description")]
        public string WebDescription { get; set; }
    
        [JsonProperty("city")]
        public string City { get; set; }
    
        [JsonProperty("state")]
        public string State { get; set; }
    
        [JsonProperty("film_rating")]
        public bool? FilmRating { get; set; }
    
        [JsonProperty("critic_name")]
        public string CriticName { get; set; }
    
        [JsonProperty("times_pick")]
        public bool? TimesPick { get; set; }
    
        [JsonProperty("free")]
        public bool? Free { get; set; }
    
        [JsonProperty("kid_friendly")]
        public bool? KidFriendly { get; set; }
    
        [JsonProperty("last_chance")]
        public bool? LastChance { get; set; }
    
        [JsonProperty("festival")]
        public bool? Festival { get; set; }
    
        [JsonProperty("long_running_show")]
        public bool? LongRunningShow { get; set; }
    
        [JsonProperty("previews_and_openings")]
        public bool? PreviewsAndOpenings { get; set; }
    
        [JsonProperty("recurring_start_date")]
        public string RecurringStartDate { get; set; }
    
        [JsonProperty("recur_days")]
        public IEnumerable<string> RecurDays { get; set; }
    }
}
