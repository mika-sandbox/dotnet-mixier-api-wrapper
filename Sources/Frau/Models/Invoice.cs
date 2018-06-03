using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class Invoice
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("user")]
        public uint User { get; set; }

        [JsonProperty("createdAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("items")]
        public List<InvoiceItem> Items { get; set; }
    }
}