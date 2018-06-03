using Newtonsoft.Json;

namespace Frau.Models
{
    public class Share : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("relid")]
        public string Relid { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("userId")]
        public uint? UserId { get; set; }
    }
}