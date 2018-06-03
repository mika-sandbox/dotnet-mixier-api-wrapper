using Newtonsoft.Json;

namespace Frau.Models
{
    // ReSharper disable once InconsistentNaming
    public class CPMAnalytic : ChannelAnalytic
    {
        [JsonProperty("impressions")]
        public uint Impressions { get; set; }

        [JsonProperty("payout")]
        public int Payout { get; set; }
    }
}