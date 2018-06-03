using Newtonsoft.Json;

namespace Frau.Models
{
    public class Announcement
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("timeout")]
        public int? Timeout { get; set; }

        [JsonProperty("sound")]
        public string Sound { get; set; }

        [JsonProperty("level")]
        public string Level { get; set; }

        [JsonProperty("confetti")]
        public object Confetti { get; set; }
    }
}