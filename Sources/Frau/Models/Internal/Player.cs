using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Player
    {
        [JsonProperty("channelId")]
        public int ChannelId { get; set; }

        [JsonProperty("lowLatency")]
        public bool LowLatency { get; set; }

        [JsonProperty("interactivePinned")]
        public bool InteractivePinned { get; set; }

        [JsonProperty("volume")]
        public double Volume { get; set; }

        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }
    }
}