using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    // は？
    public class UserWithChannelExtended : UserWithChannel
    {
        [JsonProperty("groups")]
        public List<UserGroup> Groups { get; set; }
    }
}