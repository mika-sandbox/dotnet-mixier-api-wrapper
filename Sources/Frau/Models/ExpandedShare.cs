using Newtonsoft.Json;

namespace Frau.Models
{
    public class ExpandedShare : Share
    {
        [JsonProperty("user")]
        public User User { get; set; }
    }
}