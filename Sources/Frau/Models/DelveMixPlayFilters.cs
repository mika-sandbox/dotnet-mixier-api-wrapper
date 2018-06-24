using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class DelveMixPlayFilters
    {
        [JsonProperty("nae")]
        public object Name { get; set; }

        [JsonProperty("descriptionn")]
        public object Description { get; set; }

        [JsonProperty("integrationIds")]
        public List<uint> IntegrationIds { get; set; }
    }
}