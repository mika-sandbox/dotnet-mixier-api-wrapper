using Newtonsoft.Json;

namespace Frau.Models
{
    public class FollowersAnalytic : ChannelAnalytic
    {
        [JsonProperty("total")]
        public uint Total { get; set; }

        [JsonProperty("delta")]
        public int Delta { get; set; }

        [JsonProperty("user")]
        public int? User { get; set; }
    }
}