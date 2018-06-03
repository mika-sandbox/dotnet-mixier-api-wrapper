using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveScreenAnalysis
    {
        [JsonProperty("position")]
        public Position Position { get; set; }

        [JsonProperty("clicks")]
        public bool Clicks { get; set; }
    }
}