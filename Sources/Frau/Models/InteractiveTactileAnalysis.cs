using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveTactileAnalysis
    {
        [JsonProperty("holding")]
        public bool Holding { get; set; }

        [JsonProperty("frequency")]
        public bool Frequency { get; set; }
    }
}