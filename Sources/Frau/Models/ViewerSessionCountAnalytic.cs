using Newtonsoft.Json;

namespace Frau.Models
{
    public class ViewerSessionCountAnalytic : ChannelAnalytic
    {
        [JsonProperty("count")]
        public uint Count { get; set; }
    }
}