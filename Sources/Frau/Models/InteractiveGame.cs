using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveGame : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("ownerId")]
        public uint OwnerId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("coverUrl")]
        public string CoverUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("hasPublishedVersions")]
        public bool HasPublishedVersions { get; set; }

        [JsonProperty("typeId")]
        public uint TypeId { get; set; }

        [JsonProperty("installation")]
        public string Installation { get; set; }
    }
}