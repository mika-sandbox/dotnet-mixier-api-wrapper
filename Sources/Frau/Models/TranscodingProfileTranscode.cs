using Newtonsoft.Json;

namespace Frau.Models
{
    public class TranscodingProfileTranscode
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("width")]
        public uint Width { get; set; }

        [JsonProperty("height")]
        public uint Height { get; set; }

        [JsonProperty("bitrate")]
        public uint Bitrate { get; set; }

        [JsonProperty("fps")]
        // ReSharper disable once InconsistentNaming
        public uint FPS { get; set; }

        [JsonProperty("requirePartner")]
        public bool RequirePartner { get; set; }
    }
}