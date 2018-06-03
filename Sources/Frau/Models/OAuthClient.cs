using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class OAuthClient
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("hosts")]
        public List<string> Hosts { get; set; }
    }
}