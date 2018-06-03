using Newtonsoft.Json;

namespace Frau.Models
{
    public class Follow : TimeStamped
    {
        [JsonProperty("user")]
        public uint User { get; set; }

        [JsonProperty("channel")]
        public uint Channel { get; set; }
    }
}