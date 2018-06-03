using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class BotRole
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("roleId")]
        public string RoleId { get; set; }

        [JsonProperty("gracePeriod")]
        public uint GracePeriod { get; set; }
    }
}