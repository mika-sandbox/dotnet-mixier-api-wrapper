using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class PartyChatSubscription
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("connection")]
        public string Connection { get; set; }

        [JsonProperty("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonProperty("changeTypes")]
        public List<string> ChangeTypes { get; set; }
    }
}