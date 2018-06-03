using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    // ReSharper disable once InconsistentNaming
    public class FTLVideoManifest
    {
        // FIXME https://dev.mixer.com/rest.html#FTLVideoManifest
        [JsonProperty("resolutions")]
        public List<VideoManifestResolution> Resolutions { get; set; }

        [JsonProperty("since")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime Since { get; set; }
    }
}