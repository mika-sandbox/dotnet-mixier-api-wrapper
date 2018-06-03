using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class PartnershipApp : TimeStamped
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("reapplies")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? Reapplies { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}