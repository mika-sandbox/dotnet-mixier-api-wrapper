using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class FrontendVersion
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}