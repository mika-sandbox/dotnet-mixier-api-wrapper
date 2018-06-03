using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ExpandedChannel : ChannelAdvanced
    {
        [JsonProperty("thumbnal")]
        public Resource Thumbnail { get; set; }

        [JsonProperty("cover")]
        public Resource Cover { get; set; }

        [JsonProperty("badge")]
        public Resource Badge { get; set; }

        [Obsolete]
        [JsonProperty("cache")]
        public List<object> Cache { get; set; }

        [JsonProperty("preferences")]
        public ChannelPreferences Preferences { get; set; }
    }
}