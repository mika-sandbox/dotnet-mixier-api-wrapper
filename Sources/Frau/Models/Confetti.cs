using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class Confetti
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("channelId")]
        public uint? ChannelId { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }
    }
}