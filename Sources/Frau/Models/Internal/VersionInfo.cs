using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class VersionInfo
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("versionOrder")]
        public uint VersionOrder { get; set; }
    }
}