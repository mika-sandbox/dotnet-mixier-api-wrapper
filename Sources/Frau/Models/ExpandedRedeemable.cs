using Newtonsoft.Json;

namespace Frau.Models
{
    public class ExpandedRedeemable : Redeemable
    {
        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("redeemedBy")]
        public User RedeemedBy { get; set; }
    }
}