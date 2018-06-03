using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class UserLog
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("eventData")]
        public object EventData { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("sourceData")]
        public object SourceData { get; set; }

        [JsonProperty("createdAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }
    }
}