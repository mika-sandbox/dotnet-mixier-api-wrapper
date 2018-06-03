using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Screen
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("blueprint")]
        public List<Blueprint> Blueprint { get; set; }

        [JsonProperty("analysis")]
        public InteractiveScreenAnalysis Analysis { get; set; }
    }
}