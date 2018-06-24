using System.Collections.Generic;

using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class ChatPrepare
    {
        [JsonProperty("endpoints")]
        public List<string> Endpoints { get; set; }

        [JsonProperty("authkey")]
        public string AuthKey { get; set; }

        [JsonProperty("roles")]
        public List<string> Roles { get; set; }

        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        [JsonProperty("isLoadShed")]
        public bool IsLoadShed { get; set; }
    }
}