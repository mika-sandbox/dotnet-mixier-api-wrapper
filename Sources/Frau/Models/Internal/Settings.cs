using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Settings
    {
        [JsonProperty("count")]
        public string Count { get; set; }

        [JsonProperty("particles")]
        public List<Particle> Particles { get; set; }
    }
}