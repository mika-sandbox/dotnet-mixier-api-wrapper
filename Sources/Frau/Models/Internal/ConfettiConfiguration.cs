using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class ConfettiConfiguration
    {
        [JsonProperty("shape")]
        public string Shape { get; set; }
    }
}