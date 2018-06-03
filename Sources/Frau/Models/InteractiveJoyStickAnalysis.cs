using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveJoyStickAnalysis
    {
        [JsonProperty("coords")]
        public Coords Coords { get; set; }
    }
}