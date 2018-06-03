using Newtonsoft.Json;

namespace Frau.Models
{
    public class Resource
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public uint Relid { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("store")]
        public string Store { get; set; }

        [JsonProperty("remotePath")]
        public string RemotePath { get; set; }

        [JsonProperty("meta")]
        public object Meta { get; set; }
    }
}