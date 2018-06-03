using Newtonsoft.Json;

namespace Frau.Models
{
    public class SubscriptionsAnalytic : ChannelAnalytic
    {
        [JsonProperty("total")]
        public uint Total { get; set; }

        [JsonProperty("delta")]
        public int Delta { get; set; }

        [JsonProperty("user")]
        public uint User { get; set; }
    }
}