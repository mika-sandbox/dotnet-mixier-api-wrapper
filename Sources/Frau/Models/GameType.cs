using Newtonsoft.Json;

namespace Frau.Models
{
    public class GameType : GameTypeSimple
    {
        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("viewersCurrent")]
        public uint ViewersCurrent { get; set; }

        [JsonProperty("online")]
        public uint Online { get; set; }
    }
}