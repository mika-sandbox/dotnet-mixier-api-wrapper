using Newtonsoft.Json;

namespace Frau.Models
{
    public class User : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("level")]
        public uint Level { get; set; }

        [JsonProperty("social")]
        public SocialInfo Social { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("experience")]
        public uint Experience { get; set; }

        [JsonProperty("sparks")]
        public uint Sparks { get; set; }

        [JsonProperty("avatarUrl")]
        public string AvatarUrl { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("primaryTeam")]
        public uint? PrimaryTeam { get; set; }
    }
}