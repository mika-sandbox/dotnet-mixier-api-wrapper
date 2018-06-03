using Newtonsoft.Json;

namespace Frau.Models
{
    public class SubscriptionExpanded : Subscription
    {
        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("group")]
        public UserGroup Group { get; set; }
    }
}