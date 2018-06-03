using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Particle
    {
        [JsonProperty("probability")]
        public int Probability { get; set; }

        [JsonProperty("velocity")]
        public string Velocity { get; set; }

        [JsonProperty("zdepth")]
        public string Zdepth { get; set; }

        [JsonProperty("wiggleMagnitude")]
        public string WiggleMagnitude { get; set; }

        [JsonProperty("wigglePeriod")]
        public string WigglePeriod { get; set; }

        [JsonProperty("lifetime")]
        public string Lifetime { get; set; }

        [JsonProperty("fader")]
        public string Fader { get; set; }

        [JsonProperty("draw")]
        public ConfettiConfiguration Draw { get; set; }
    }
}