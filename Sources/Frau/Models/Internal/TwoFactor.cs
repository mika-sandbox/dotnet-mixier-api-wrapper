using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class TwoFactor
    {
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("codesViewed")]
        public bool CodesViewed { get; set; }
    }
}