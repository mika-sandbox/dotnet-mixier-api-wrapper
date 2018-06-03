using Newtonsoft.Json;

namespace Frau.Models
{
    public class GameRankAnalytic : ChannelAnalytic
    {
        [JsonProperty("streams")]
        public uint Streams { get; set; }

        [JsonProperty("views")]
        public uint Views { get; set; }

        [JsonProperty("shared")]
        public uint Shared { get; set; }
    }
}