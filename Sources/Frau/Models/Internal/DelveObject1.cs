using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class DelveObject1 : DelveObjectBase
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("type")]
        public GameType Type { get; set; }
    }
}