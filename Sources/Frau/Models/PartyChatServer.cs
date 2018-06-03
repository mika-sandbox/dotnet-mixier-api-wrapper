using Newtonsoft.Json;

namespace Frau.Models
{
    public class PartyChatServer
    {
        [JsonProperty("serverFqdn")]
        public string ServerFqdn { get; set; }

        [JsonProperty("targetLocation")]
        public string TargetLocation { get; set; }
    }
}