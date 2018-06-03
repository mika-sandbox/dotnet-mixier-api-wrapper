using Newtonsoft.Json;

namespace Frau.Models
{
    public class PartyChatMemberRef
    {
        [JsonProperty("partyId")]
        public string PartyId { get; set; }

        [JsonProperty("gamertag")]
        public string Gamertag { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }
}