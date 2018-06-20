using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class RelationShipStatus
    {
        [JsonProperty("roles")]
        public List<string> Role { get; set; }

        [JsonProperty("follows")]
        public Follow Follows { get; set; }
    }
}