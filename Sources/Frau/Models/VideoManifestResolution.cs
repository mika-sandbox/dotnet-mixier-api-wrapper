using Newtonsoft.Json;

namespace Frau.Models
{
    public class VideoManifestResolution
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("width")]
        public uint? Width { get; set; }

        [JsonProperty("height")]
        public uint? Height { get; set; }

        [JsonProperty("hasVideo")]
        public bool HasVideo { get; set; }

        [JsonProperty("bitrate")]
        public uint Bitrate { get; set; }
    }
}