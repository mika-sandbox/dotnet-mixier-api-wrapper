using Newtonsoft.Json;

namespace Frau.Models
{
    public class Delve
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}