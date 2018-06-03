using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class LightVideoManifest
    {
        [JsonProperty("resolutions")]
        public List<VideoManifestResolution> Resolutions { get; set; }

        [JsonProperty("sinceId")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime SinceId { get; set; }
    }
}