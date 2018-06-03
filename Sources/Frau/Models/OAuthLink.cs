using Newtonsoft.Json;

namespace Frau.Models
{
    public class OAuthLink
    {
        [JsonProperty("service")]
        public string Service { get; set; }

        [JsonProperty("serviceId")]
        public string ServiceId { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }
    }
}