using Newtonsoft.Json;

namespace Frau.Models
{
    public class TeamMembership : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("teamId")]
        public uint TeamId { get; set; }

        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("accepted")]
        public bool Accepted { get; set; }
    }
}