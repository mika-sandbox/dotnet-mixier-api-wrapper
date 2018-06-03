using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class AnalyticsData
    {
        [JsonProperty("avg")]
        public int Avg { get; set; }

        [JsonProperty("max")]
        public int Max { get; set; }

        [JsonProperty("min")]
        public int Min { get; set; }

        [JsonProperty("std")]
        public int Std { get; set; }
    }
}