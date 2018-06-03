using Newtonsoft.Json;

namespace Frau.Models
{
    public class TeamMembershipExpanded : TeamMembership
    {
        [JsonProperty("isPrimary")]
        public bool IsPrimary { get; set; }

        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("teamMembership")]
        public TeamMembership TeamMembership { get; set; }
    }
}