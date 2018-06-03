using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models.Internal
{
    public class Notification
    {
        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("sentAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime SentAt { get; set; }

        [JsonProperty("trigger")]
        public string Trigger { get; set; }

        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
}