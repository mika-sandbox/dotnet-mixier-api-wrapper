using Newtonsoft.Json;

namespace Frau.Models
{
    public class UserGroup : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("role")]
        public string Role { get; set; }
    }
}