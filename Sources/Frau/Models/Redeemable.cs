using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class Redeemable : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("ownerId")]
        public uint OwnerId { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("redeemedById")]
        public uint? RedeemedById { get; set; }

        [JsonProperty("redeemedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? RedeemedAt { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }
    }
}