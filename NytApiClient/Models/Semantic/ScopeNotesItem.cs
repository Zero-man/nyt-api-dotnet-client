using System.Collections.Generic;
using Newtonsoft.Json;

namespace NytApiClient
{
    public class ScopeNotesItem
    {
        [JsonProperty("scope_note")]
        public string ScopeNote { get; set; }

        [JsonProperty("scope_note_name")]
        public string ScopeNoteName { get; set; }

        [JsonProperty("scope_note_type")]
        public string ScopeNoteType { get; set; }
    }
}
