using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class InteractiveGameListing : InteractiveGame
    {
        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("versions")]
        public List<VersionInfo> Versions { get; set; }
    }
}