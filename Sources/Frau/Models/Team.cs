using Newtonsoft.Json;

namespace Frau.Models
{
    public class Team : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("ownerId")]
        public uint OwnerId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }

        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }

        [JsonProperty("social")]
        public SocialInfo Social { get; set; }
    }
}