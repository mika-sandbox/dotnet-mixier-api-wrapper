using Newtonsoft.Json;

namespace Frau.Models
{
    public class EmojiRankAnalytic : ChannelAnalytic
    {
        [JsonProperty("emoji")]
        public string Emoji { get; set; }

        [JsonProperty("count")]
        public uint Count { get; set; }
    }
}