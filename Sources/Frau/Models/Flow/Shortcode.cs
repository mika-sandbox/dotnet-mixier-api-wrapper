using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class Shortcode
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("handle")]
        public string Handle { get; set; }

        [JsonProperty("expires_in")]
        public uint ExpiresIn { get; set; }
    }
}