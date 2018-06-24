using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class DelveHome
    {
        [JsonProperty("rows")]
        public List<Delve> Rows { get; set; }

        [JsonProperty("mixPlayFilters")]
        public List<DelveMixPlayFilters> MixPlayFilters { get; set; }

        [JsonProperty("background")]
        public DelveBackground Background { get; set; }
    }
}