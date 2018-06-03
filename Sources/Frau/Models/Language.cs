using Newtonsoft.Json;

namespace Frau.Models
{
    public class Language
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}