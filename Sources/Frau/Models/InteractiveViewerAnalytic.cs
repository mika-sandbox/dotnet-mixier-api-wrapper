using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveViewerAnalytic : ChannelAnalytic
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("channelId")]
        public int? ChannelId { get; set; }
    }
}