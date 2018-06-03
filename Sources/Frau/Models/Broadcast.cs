using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class Broadcast
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("channelId")]
        public uint ChannelId { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("isTestStream")]
        public bool IsTestStream { get; set; }

        [JsonProperty("startedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime StartedAt { get; set; }
    }
}