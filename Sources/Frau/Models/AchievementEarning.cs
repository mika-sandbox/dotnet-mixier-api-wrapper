using Newtonsoft.Json;

namespace Frau.Models
{
    public class AchievementEarning : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("earned")]
        public bool Earned { get; set; }

        [JsonProperty("progress")]
        public int Progress { get; set; }

        [JsonProperty("achievement")]
        public string Name { get; set; }

        [JsonProperty("user")]
        public uint User { get; set; }

        [JsonProperty("Achievement")]
        public Achievement Achievement { get; set; }
    }
}