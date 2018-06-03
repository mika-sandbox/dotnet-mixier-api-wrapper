using Newtonsoft.Json;

namespace Frau.Models
{
    public class DiscordRole
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("assignable")]
        public bool Assignable { get; set; }
    }
}