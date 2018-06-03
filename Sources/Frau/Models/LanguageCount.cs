using Newtonsoft.Json;

namespace Frau.Models
{
    public class LanguageCount
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("count")]
        public uint Count { get; set; }
    }
}