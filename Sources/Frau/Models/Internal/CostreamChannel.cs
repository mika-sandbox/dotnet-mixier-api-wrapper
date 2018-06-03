using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class CostreamChannel
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}