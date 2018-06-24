using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class DelveObjectBase
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("viewersCurrent")]
        public uint ViewersCurrent { get; set; }
    }
}