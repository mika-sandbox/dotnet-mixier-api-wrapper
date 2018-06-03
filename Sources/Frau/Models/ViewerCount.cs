using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class ViewerCount
    {
        [JsonProperty("time")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Time { get; set; }

        [JsonProperty("anon")]
        public uint Anon { get; set; }

        [JsonProperty("authed")]
        public uint Authed { get; set; }
    }
}