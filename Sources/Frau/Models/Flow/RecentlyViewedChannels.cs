using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class RecentlyViewedChannels
    {
        [JsonProperty("channels")]
        public List<ChannelAdvanced> Channels { get; set; }

        [JsonProperty("page")]
        public uint Page { get; set; }
    }
}