using Newtonsoft.Json;

namespace Frau.Models
{
    public class GameTypeLookup : GameTypeSimple
    {
        [JsonProperty("exact")]
        public bool Exact { get; set; }
    }
}