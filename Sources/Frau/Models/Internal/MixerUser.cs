using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class MixerUser
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}