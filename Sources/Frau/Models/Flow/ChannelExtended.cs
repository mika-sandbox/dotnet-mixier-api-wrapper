using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class ChannelExtended : Channel
    {
        [JsonProperty("thumbnail")]
        public Resource Thumbnail { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("type")]
        public GameType Type { get; set; }
    }
}