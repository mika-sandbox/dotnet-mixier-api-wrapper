using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class StreamViewer
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("broadcastId")]
        public string BroadcastId { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("costreamDepth")]
        public string CostreamDepth { get; set; }

        [JsonProperty("durationInSeconds")]
        public int DurationInSeconds { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("timestamp")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Timestamp { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("typeId")]
        public string TypeId { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }
    }
}