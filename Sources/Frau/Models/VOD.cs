using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    // ReSharper disable once InconsistentNaming
    public class VOD : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("baseUrl")]
        public string BaseUrl { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }

        [JsonProperty("data")]
        public VodInfo Data { get; set; }

        [JsonProperty("recordingId")]
        public uint RecordingId { get; set; }
    }
}