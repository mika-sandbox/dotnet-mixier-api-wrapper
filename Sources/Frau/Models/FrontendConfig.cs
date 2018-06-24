using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class FrontendConfig
    {
        [JsonProperty("alwaysOnline")]
        public List<uint> AlwaysOnline { get; set; }

        [JsonProperty("features")]
        public object Features { get; set; }
    }
}