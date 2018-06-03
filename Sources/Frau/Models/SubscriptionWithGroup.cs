using Newtonsoft.Json;

namespace Frau.Models
{
    public class SubscriptionWithGroup : Subscription
    {
        [JsonProperty("group")]
        public uint GroupId { get; set; }

        [JsonProperty("Group")]
        public UserGroup Group { get; set; }
    }
}