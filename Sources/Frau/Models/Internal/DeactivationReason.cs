using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class DeactivationReason
    {
        [JsonProperty("code")]
        public uint Code { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}