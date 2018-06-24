using Newtonsoft.Json;

namespace Frau.Models
{
    public class DelveError : Delve
    {
        [JsonProperty("originalType")]
        public string OriginalType { get; set; }
    }
}