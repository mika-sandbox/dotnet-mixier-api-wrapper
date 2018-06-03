using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class PrivatePopulatedUser : PrivateUser
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }

        [JsonProperty("groups")]
        public List<UserGroup> Groups { get; set; }

        [JsonProperty("preferences")]
        public UserPreferences Preferences { get; set; }
    }
}