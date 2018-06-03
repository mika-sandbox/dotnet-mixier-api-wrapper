using Newtonsoft.Json;

namespace Frau.Models
{
    public class TranscodingProfile
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}