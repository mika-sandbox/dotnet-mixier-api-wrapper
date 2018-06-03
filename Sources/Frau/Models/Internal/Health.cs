using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Health
    {
        [JsonProperty("eat")]
        public int Eat { get; set; }

        [JsonProperty("stretch")]
        public int Stretch { get; set; }
    }
}