using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ConfettiCircle : ConfettiConfiguration
    {
        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("flipPeriod")]
        public string FlipPeriod { get; set; }

        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }
    }
}