using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ExpandedTranscodingProfile : TranscodingProfile
    {
        [JsonProperty("transcodes")]
        public List<TranscodingProfileTranscode> Transcodes { get; set; }
    }
}