using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Tactile
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("blueprint")]
        public List<Blueprint> Blueprint { get; set; }

        [JsonProperty("key")]
        public uint Key { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("cost")]
        public TactileCost Cost { get; set; }

        [JsonProperty("cooldown")]
        public Cooldown Cooldown { get; set; }

        [JsonProperty("analysis")]
        public InteractiveTactileAnalysis Analysis { get; set; }
    }
}