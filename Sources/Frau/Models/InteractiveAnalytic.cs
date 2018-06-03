using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveAnalytic : ChannelAnalytic
    {
        [JsonProperty("inputsGiven")]
        public uint InputsGiven { get; set; }

        [JsonProperty("playtime")]
        public uint Playtime { get; set; }

        [JsonProperty("streams")]
        public uint Streams { get; set; }

        [JsonProperty("viewers")]
        public uint Viewers { get; set; }

        [JsonProperty("streamLength")]
        public uint StreamLength { get; set; }

        [JsonProperty("timeToInteractive")]
        public AnalyticsData TimeToInteractive { get; set; }

        [JsonProperty("sparksSpent")]
        public AnalyticsData SparksSpent { get; set; }
    }
}