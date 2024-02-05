using CsvHelper.Configuration.Attributes;
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
        [Name("Activity Id")]
        public string? ActivityId { get; set; }

        [Name("Date")]
        public DateTime Date { get; set; }

        [Name("Type")]
        public string? Type { get; set; }

        [Name("Route Name")]
        public string? RouteName { get; set; }

        [Name("Distance (km)")]
        public double Distance { get; set; }

        [Name("Duration")]
        public string? Duration { get; set; }

        [Name("Average Pace")]
        public string? AveragePace { get; set; }

        [Name("Average Speed (km/h)")]
        public string? AverageSpeed { get; set; }

        [Name("Calories Burned")]
        public float CaloriesBurned { get; set; }

        [Name("Climb (m)")]
        public int Climb { get; set; }

        [Name("Average Heart Rate (bpm)")]
        public string? AverageHeartRate { get; set; }

        [Name("Friend's Tagged")]
        public string? FriendsTagged { get; set; }

        [Name("Notes")]
        public string? Notes { get; set; }

        [Name("GPX File")]
        public string? GPXFile { get; set; }
    }

//    public class RunkeeperActivityList
//    {
//        [JsonProperty("Data", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
//        public required ICollection<RunkeeperActivity> Data { get; set; }

//        [JsonProperty("Cursor", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
//        public required RunkeeperCursorInfo Cursor { get; set; }

//        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//        [JsonExtensionData]
//        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//        {
//            get { return _additionalProperties; }
//            set { _additionalProperties = value; }
//        }
//    }

//    public class RunkeeperCursorInfo
//    {
//        / <summary>Cursor for the last entry.Used to fetch next page when using cursor based pagination.Will be empty at EOF.</summary>
//        [Newtonsoft.Json.JsonProperty("Last", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public required string Last { get; set; }

//        / <summary>Only used by some endpoints.Bookmark to use to get the next page of hits.If 0, no more hits exists (EOF).</summary>
//        [Newtonsoft.Json.JsonProperty("Bookmark", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
//        public long Bookmark { get; set; }

//    private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

//    [Newtonsoft.Json.JsonExtensionData]
//    public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
//    {
//        get { return _additionalProperties; }
//        set { _additionalProperties = value; }
//    }

//}
    //generererat av code completion:
    //public class RunkeeperActivityFeed
    //{
    //    public string previous { get; set; }
    //    public string next { get; set; }
    //    public List<RunkeeperActivity> items { get; set; }
    //}
}