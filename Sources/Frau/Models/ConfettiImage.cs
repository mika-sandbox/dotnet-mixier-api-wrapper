using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ConfettiImage : ConfettiConfiguration
    {
        [JsonProperty("scale")]
        public string Scale { get; set; }

        [JsonProperty("spinPeriod")]
        public string SpinPeriod { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}