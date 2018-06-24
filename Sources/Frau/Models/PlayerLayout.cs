using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class PlayerLayout
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public List<int> Order { get; set; }

        [JsonProperty("players")]
        public List<Player> Players { get; set; }
    }
}