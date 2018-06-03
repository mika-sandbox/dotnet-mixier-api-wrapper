using Newtonsoft.Json;

namespace Frau.Models
{
    public class CheckoutItem
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("quantity")]
        public uint Quantity { get; set; }
    }
}