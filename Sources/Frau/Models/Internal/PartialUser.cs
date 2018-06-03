using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class PartialUser
    {
        [JsonProperty("experience")]
        public uint Experience { get; set; }

        [JsonProperty("level")]
        public uint Level { get; set; }
    }
}