using System;
using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class Costream
    {
        [JsonProperty("channels")]
        public List<CostreamChannel> Channels { get; set; }

        [JsonProperty("startedAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime StartedAt { get; set; }

        [JsonProperty("capacity")]
        public uint Capacity { get; set; }

        [JsonProperty("interactivePinnedChannelId")]
        public uint InteractivePinnedChannelId { get; set; }

        [JsonProperty("layout")]
        public CostreamLayout Layout { get; set; }
    }
}