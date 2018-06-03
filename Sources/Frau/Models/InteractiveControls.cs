using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveControls
    {
        [JsonProperty("reportInterval")]
        public uint ReportInterval { get; set; }

        [JsonProperty("joysticks")]
        public List<Joystick> Joysticks { get; set; }

        [JsonProperty("screens")]
        public List<Screen> Screens { get; set; }

        [JsonProperty("tactiles")]
        public List<Tactile> Tactiles { get; set; }

        [JsonProperty("analysis")]
        public InteractiveTactileAnalysis Analysis { get; set; }
    }
}