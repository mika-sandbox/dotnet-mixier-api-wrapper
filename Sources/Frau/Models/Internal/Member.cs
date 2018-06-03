using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Member
    {
        [JsonProperty("gamertag")]
        public string Gamertag { get; set; }

        [JsonProperty("simpleConnectionState")]
        public int SimpleConnectionState { get; set; }

        [JsonProperty("mixerUser")]
        public MixerUser MixerUser { get; set; }

        [JsonProperty("ref")]
        public PartyChatMemberRef Ref { get; set; }
    }
}