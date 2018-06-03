using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class ChannelAnalytic
    {
        [JsonProperty("channel")]
        public uint Channel { get; set; }

        [JsonProperty("time")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Time { get; set; }
    }
}