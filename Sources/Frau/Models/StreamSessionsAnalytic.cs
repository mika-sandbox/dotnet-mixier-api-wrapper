using Newtonsoft.Json;

namespace Frau.Models
{
    public class StreamSessionsAnalytic : ChannelAnalytic
    {
        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("duration")]
        public uint? Duration { get; set; }

        [JsonProperty("type")]
        public uint? Type { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }
    }
}