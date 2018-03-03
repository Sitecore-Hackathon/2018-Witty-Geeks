using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WittyGeeks.Hackathon.Foundation.SitecoreExtensions.Models.Json
{
    public class StickyNotes
    {
        [JsonProperty("items")]
        public IEnumerable<StickyNote> notesOnAnItem { get; set; }
    }

    public class StickyNote
    {
        [JsonProperty("id")]
        public string id { get; set; }
        [JsonProperty("properties")]
        public StickyNoteDetails Properties { get; set; }
        
    }

    public class StickyNoteDetails
    {
       
        [JsonProperty("text")]
        public string Text { get; set; }      
       
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("date")]
        public string DateCreated { get; set; }
       
        [JsonProperty("userName")]
        public string UserName { get; set; }
         
    }
}