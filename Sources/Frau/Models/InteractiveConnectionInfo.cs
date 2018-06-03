using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveConnectionInfo
    {
        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("influence")]
        public int Influence { get; set; }

        [JsonProperty("version")]
        public InteractiveVersionExpanded Version { get; set; }
    }
}