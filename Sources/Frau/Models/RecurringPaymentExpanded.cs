using Newtonsoft.Json;

namespace Frau.Models
{
    public class RecurringPaymentExpanded : RecurringPayment
    {
        [JsonProperty("subscription")]
        public SubscriptionExpanded Subscription { get; set; }
    }
}