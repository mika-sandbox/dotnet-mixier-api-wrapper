using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class EmoticonPack
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("emoticons")]
        public List<object> Emoticons { get; set; }

        [JsonProperty("channelId")]
        public uint ChannelId { get; set; }
    }
}