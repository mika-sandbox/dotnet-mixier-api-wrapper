using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveVersion : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("gameId")]
        public uint GameId { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("versionOrder")]
        public uint VersionOrder { get; set; }

        [JsonProperty("changelog")]
        public string Changelog { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("installation")]
        public string Installation { get; set; }

        [JsonProperty("download")]
        public string Download { get; set; }

        [JsonProperty("controls")]
        public InteractiveControls Controls { get; set; }

        [JsonProperty("controlVersion")]
        public string ControlVersion { get; set; }

        [JsonProperty("bundle")]
        public string Bundle { get; set; }
    }
}