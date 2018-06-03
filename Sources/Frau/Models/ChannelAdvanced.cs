using Newtonsoft.Json;

namespace Frau.Models
{
    public class ChannelAdvanced : Channel
    {
        [JsonProperty("type")]
        public GameType Type { get; set; }
    }
}