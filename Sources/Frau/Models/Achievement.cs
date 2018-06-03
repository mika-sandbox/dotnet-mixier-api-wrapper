using Newtonsoft.Json;

namespace Frau.Models
{
    public class Achievement
    {
        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sparks")]
        public uint Sparks { get; set; }
    }
}