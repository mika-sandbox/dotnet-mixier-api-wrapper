using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class Introspect
    {
        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}