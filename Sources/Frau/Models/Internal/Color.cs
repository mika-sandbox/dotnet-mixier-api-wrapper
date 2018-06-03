using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Color
    {
        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("r")]
        public string R { get; set; }

        [JsonProperty("g")]
        public string G { get; set; }

        [JsonProperty("b")]
        public string B { get; set; }
    }
}