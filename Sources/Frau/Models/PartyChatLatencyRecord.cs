using System.Diagnostics;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class PartyChatLatencyRecord
    {
        [JsonProperty("serverFqdn")]
        public string ServerFqdn { get; set; }

        [JsonProperty("targetLocation")]
        public StackTrace TargetLocation { get; set; }
    }
}