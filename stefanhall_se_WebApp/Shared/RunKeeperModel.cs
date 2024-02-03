//using RestSharp.Authenticators;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//using System.Configuration;
//using HealthGraphNet;
//using HealthGraphNet.Models;

using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace stefanhall_se_WebApp.Shared
{
    public class RunkeeperDetails
    {
        private static string Mask
        {
            get { return "some text"; }
        }

        public string? latHeader { get; set; }
        public string? longHeader { get; set; }
        public char separator1 { get; set; }
        public char separator2 { get; set; }
        public char separator3 { get; set; }
        public string? latitude { get; set; }
        public string? longitude { get; set; }
    }
    public class RunkeeperActivity
    {
        [JsonProperty("utc_offset", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int utc_offset {get; set;}
        
        [JsonProperty("Duration", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int Duration { get; set; }
        
        [JsonProperty("start_time", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTime start_time { get; set; }
        
        [JsonProperty("total_calories", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float total_calories { get; set; }
        
        [JsonProperty("tracking_mode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string tracking_mode { get; set; }
        
        [JsonProperty("total_distance", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float total_distance { get; set; }
        
        [JsonProperty("entry_mode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string entry_mode { get; set; }

        [JsonProperty("has_path", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool has_path { get; set; }

        [JsonProperty("share", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string share { get; set; }

        [JsonProperty("source", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string source { get; set; }

        [JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string type { get; set; }

        [JsonProperty("uri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string uri { get; set; }

        [JsonProperty("pace", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public float pace { get; set; }

        [JsonProperty("climb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string climb { get; set; }
    }

    public class RunkeeperActivityList
    {
        [JsonProperty("Data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public required ICollection<RunkeeperActivity> Data { get; set; }

        [JsonProperty("Cursor", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public required RunkeeperCursorInfo Cursor { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }

    public class RunkeeperCursorInfo
    {
        /// <summary>Cursor for the last entry. Used to fetch next page when using cursor based pagination. Will be empty at EOF.</summary>
        [Newtonsoft.Json.JsonProperty("Last", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public required string Last { get; set; }

        /// <summary>Only used by some endpoints. Bookmark to use to get the next page of hits. If 0, no more hits exists (EOF).</summary>
        [Newtonsoft.Json.JsonProperty("Bookmark", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long Bookmark { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }

    }
    //generererat av code completion:
    //public class RunkeeperActivityFeed
    //{
    //    public string previous { get; set; }
    //    public string next { get; set; }
    //    public List<RunkeeperActivity> items { get; set; }
    //}
}