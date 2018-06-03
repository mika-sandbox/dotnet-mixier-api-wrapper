using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class TactileCost
    {
        [JsonProperty("press")]
        public Press Press { get; set; }
    }
}