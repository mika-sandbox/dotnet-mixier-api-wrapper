using Newtonsoft.Json;

namespace Frau.Models
{
    public class DelveBackground
    {
        [JsonProperty("fullWidthSrc")]
        public string FullWidthSrc { get; set; }

        [JsonProperty("leftSrc")]
        public string LeftSrc { get; set; }

        [JsonProperty("rightSrc")]
        public string RightSrc { get; set; }
    }
}