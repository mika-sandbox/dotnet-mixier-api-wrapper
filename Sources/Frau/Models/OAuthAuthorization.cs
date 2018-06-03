using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class OAuthAuthorization
    {
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("client")]
        public OAuthClient Client { get; set; }
    }
}