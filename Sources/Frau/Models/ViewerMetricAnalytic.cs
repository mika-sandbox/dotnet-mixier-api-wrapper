using Newtonsoft.Json;

namespace Frau.Models
{
    public class ViewerMetricAnalytic
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }
    }
}