using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class TimeStamped
    {
        [JsonProperty("createdAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("deletedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? DeletedAt { get; set; }
    }
}