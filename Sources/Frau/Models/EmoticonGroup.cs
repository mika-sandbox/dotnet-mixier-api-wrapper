using Newtonsoft.Json;

namespace Frau.Models
{
    public class EmoticonGroup
    {
        [JsonProperty("x")]
        public uint X { get; set; }

        [JsonProperty("y")]
        public uint Y { get; set; }

        [JsonProperty("width")]
        public uint Width { get; set; }

        [JsonProperty("height")]
        public uint Height { get; set; }
    }
}