using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Press
    {
        [JsonProperty("cost")]
        public uint Cost { get; set; }
    }
}