using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class Recording : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("viewsTotal")]
        public uint ViewsTotal { get; set; }

        [JsonProperty("expiresAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("vods")]
        public List<VOD> Vods { get; set; }

        [JsonProperty("viewed")]
        public bool? Viewed { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("typeId")]
        public uint TypeId { get; set; }

        [JsonProperty("duration")]
        public double Duration { get; set; }

        [JsonProperty("seen")]
        public bool? Seen { get; set; }
    }
}