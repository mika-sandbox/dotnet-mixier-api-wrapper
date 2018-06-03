using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Joystick
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("blueprint")]
        public List<ExpandedBlueprint> Blueprint { get; set; }

        [JsonProperty("analysis")]
        public InteractiveJoyStickAnalysis Analysis { get; set; }
    }
}