using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class SocialInfo
    {
        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("facebook")]
        public string Facebook { get; set; }

        [JsonProperty("youtube")]
        public string Youtube { get; set; }

        [JsonProperty("player")]
        public string Player { get; set; }

        [JsonProperty("discord")]
        public string Discord { get; set; }

        [JsonProperty("verified")]
        public List<string> Verified { get; set; }
    }
}