using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class DelveCarousel : Delve
    {
        [JsonProperty("channels")]
        public List<DelveObject1> Channels { get; set; }
    }
}