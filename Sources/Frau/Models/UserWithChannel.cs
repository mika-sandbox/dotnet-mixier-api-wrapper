using Newtonsoft.Json;

namespace Frau.Models
{
    public class UserWithChannel : User
    {
        [JsonProperty("channel")]
        public Channel Channel { get; set; }
    }
}