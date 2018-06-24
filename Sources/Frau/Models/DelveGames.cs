using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class DelveGames : Delve
    {
        [JsonProperty("title")]
        public object Title { get; set; }

        [JsonProperty("continuation")]
        public string Continuation { get; set; }

        [JsonProperty("results")]
        public List<DelveObject3> Results { get; set; }
    }
}