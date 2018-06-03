using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Cooldown
    {
        [JsonProperty("press")]
        public uint? Press { get; set; }
    }
}