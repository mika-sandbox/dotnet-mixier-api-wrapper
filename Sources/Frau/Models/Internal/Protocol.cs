using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Protocol
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}