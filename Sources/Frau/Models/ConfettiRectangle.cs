using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ConfettiRectangle : ConfettiConfiguration
    {
        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("flipPeriod")]
        public string FlipPeriod { get; set; }

        [JsonProperty("colors")]
        public List<Color> Colors { get; set; }
    }
}