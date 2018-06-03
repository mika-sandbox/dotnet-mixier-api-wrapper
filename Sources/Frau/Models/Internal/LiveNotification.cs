using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class LiveNotification
    {
        [JsonProperty("channelId")]
        public string ChannelId { get; set; }

        [JsonProperty("kind")]
        public List<string> Kind { get; set; }
    }
}