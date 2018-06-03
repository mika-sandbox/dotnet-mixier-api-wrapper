using Newtonsoft.Json;

namespace Frau.Models
{
    public class GameTypeSimple
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coverUrl")]
        public string CoverUrl { get; set; }

        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }
    }
}