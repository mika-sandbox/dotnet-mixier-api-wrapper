using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class ChatUser
    {
        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("userName")]
        public string UserName { get; set; }

        [JsonProperty("userRoles")]
        public List<string> UserRoles { get; set; }

        [JsonProperty("user")]
        public PartialUser User { get; set; }
    }
}