using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class Ingest
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("pingTest")]
        public string PingTest { get; set; }

        [JsonProperty("protocols")]
        public List<Protocol> Protocols { get; set; }
    }
}