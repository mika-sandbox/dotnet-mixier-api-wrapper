using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class Session
    {
        [JsonProperty("expires")]
        public uint Expires { get; set; }

        [JsonProperty("meta")]
        public SessionMetadata Meta { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}