using Newtonsoft.Json;

namespace Frau.Models
{
    public class RedeemablePartner : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("redeemableId")]
        public uint RedeemableId { get; set; }

        [JsonProperty("partnerId")]
        public uint PartnerId { get; set; }
    }
}