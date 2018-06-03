using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ChannelSuggestions
    {
        [JsonProperty("channels")]
        public List<Channel> Channels { get; set; }

        [JsonProperty("impressionUrl")]
        public string ImpressionUrl { get; set; }

        [JsonProperty("actionsUrl")]
        public string ActionsUrl { get; set; }
    }
}