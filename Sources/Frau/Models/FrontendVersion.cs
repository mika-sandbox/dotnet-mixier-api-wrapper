using Newtonsoft.Json;

namespace Frau.Models
{
    public class FrontendVersion
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
    }
}