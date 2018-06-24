using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class Hydration
    {
        [JsonProperty("apiPath")]
        public string ApiPath { get; set; }

        [JsonProperty("continuation")]
        public string Continuation { get; set; }

        [JsonProperty("results")]
        public List<DelveObject2> Results { get; set; }
    }
}