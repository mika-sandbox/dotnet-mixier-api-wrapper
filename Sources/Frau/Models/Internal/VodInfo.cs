using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class VodInfo
    {
        [JsonProperty("Width")]
        public uint Width { get; set; }

        [JsonProperty("Height")]
        public uint Height { get; set; }

        [JsonProperty("Fps")]
        public int? Fps { get; set; }

        [JsonProperty("Bitrate")]
        public uint? Bitrate { get; set; }
    }
}