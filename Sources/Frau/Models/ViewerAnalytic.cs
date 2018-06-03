using Newtonsoft.Json;

namespace Frau.Models
{
    public class ViewerAnalytic : ChannelAnalytic
    {
        [JsonProperty("anon")]
        public uint Anon { get; set; }

        [JsonProperty("authed")]
        public uint Authed { get; set; }
    }
}