using Newtonsoft.Json;

namespace Frau.Models
{
    public class RecurringPayment : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public uint Relid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("cancelled")]
        public bool Cancelled { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("timesPaid")]
        public uint TimesPaid { get; set; }

        [JsonProperty("user")]
        public uint User { get; set; }
    }
}