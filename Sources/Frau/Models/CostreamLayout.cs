using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class CostreamLayout
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("order")]
        public List<int> Order { get; set; }
    }
}