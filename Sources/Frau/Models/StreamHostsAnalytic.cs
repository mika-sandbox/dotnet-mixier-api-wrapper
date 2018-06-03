using Newtonsoft.Json;

namespace Frau.Models
{
    public class StreamHostsAnalytic : ChannelAnalytic
    {
        [JsonProperty("hoster")]
        public uint? Hoster { get; set; }

        [JsonProperty("hostee")]
        public uint? Hostee { get; set; }
    }
}