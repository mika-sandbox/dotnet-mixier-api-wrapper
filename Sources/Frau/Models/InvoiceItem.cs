using Newtonsoft.Json;

namespace Frau.Models
{
    public class InvoiceItem : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public uint? Relid { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("quantity")]
        public uint Quantity { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("user")]
        public uint User { get; set; }

        [JsonProperty("invoice")]
        public uint Invoice { get; set; }
    }
}