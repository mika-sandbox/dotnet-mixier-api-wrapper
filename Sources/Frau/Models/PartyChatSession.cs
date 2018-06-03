using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class PartyChatSession
    {
        [JsonProperty("partyId")]
        public string PartyId { get; set; }

        [JsonProperty("serverConnectionCandidates")]
        public List<string> ServerConnectionCandidates { get; set; }

        [JsonProperty("members")]
        public List<Member> Members { get; set; }
    }
}