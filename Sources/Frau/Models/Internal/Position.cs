using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Position
    {
        [JsonProperty("mean")]
        public bool Mean { get; set; }

        [JsonProperty("stdDev")]
        public bool StdDev { get; set; }
    }
}