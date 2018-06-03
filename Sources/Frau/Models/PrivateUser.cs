using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class PrivateUser : User
    {
        // [JsonProperty("email")]
        // public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("twoFactor")]
        public TwoFactor TwoFactor { get; set; }
    }
}