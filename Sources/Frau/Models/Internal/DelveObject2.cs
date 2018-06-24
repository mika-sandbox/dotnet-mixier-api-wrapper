using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class DelveObject2 : DelveObject1
    {
        [JsonProperty("interactive")]
        public bool Interactive { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }
    }
}