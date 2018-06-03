using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Blueprint
    {
        [JsonProperty("state")]
        public string State { get; set; }
    }
}