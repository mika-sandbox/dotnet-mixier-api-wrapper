using Newtonsoft.Json;

namespace Frau.Models
{
    public class VideoSettings
    {
        [JsonProperty("isLightstreamEnabled")]
        public bool IsLightstreamEnabled { get; set; }
    }
}