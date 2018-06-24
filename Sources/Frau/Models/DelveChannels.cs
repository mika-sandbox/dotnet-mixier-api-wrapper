using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class DelveChannels : Delve
    {
        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("morePath")]
        public string MorePath { get; set; }

        [JsonProperty("style")]
        public string Style { get; set; }

        [JsonProperty("hydration")]
        public Hydration Hydration { get; set; }
    }
}