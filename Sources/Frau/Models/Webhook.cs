using System;
using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class Webhook
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }

        [JsonProperty("events")]
        public List<string> Events { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("renewUrl")]
        public string RenewUrl { get; set; }

        [JsonProperty("deactivationReason")]
        public DeactivationReason DeactivationReason { get; set; }
    }
}