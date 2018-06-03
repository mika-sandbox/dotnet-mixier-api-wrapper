using Newtonsoft.Json;

namespace Frau.Models
{
    public class SubRevenueAnalytic : ChannelAnalytic
    {
        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("gross")]
        public int Gross { get; set; }

        [JsonProperty("count")]
        public uint Count { get; set; }
    }
}