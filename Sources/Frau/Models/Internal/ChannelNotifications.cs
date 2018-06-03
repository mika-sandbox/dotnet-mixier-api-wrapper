using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class ChannelNotifications
    {
        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        [JsonProperty("transports")]
        public List<string> Transports { get; set; }
    }
}