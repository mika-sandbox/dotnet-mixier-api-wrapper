using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class SessionMetadata
    {
        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("cversion")]
        public string Cversion { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }
    }
}