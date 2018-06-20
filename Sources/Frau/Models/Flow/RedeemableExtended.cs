using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class RedeemableExtended : Redeemable
    {
        [JsonProperty("partnerGrant")]
        public RedeemablePartner PartnerGrant { get; set; }

        [JsonProperty("redeemedBy")]
        public User RedeemedBy { get; set; }
    }
}