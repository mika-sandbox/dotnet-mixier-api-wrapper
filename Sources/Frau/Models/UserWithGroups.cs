using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class UserWithGroups : User
    {
        [JsonProperty("groups")]
        public List<UserGroup> Groups { get; set; }
    }
}