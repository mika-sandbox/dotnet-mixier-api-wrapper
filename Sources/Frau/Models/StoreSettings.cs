using Newtonsoft.Json;

namespace Frau.Models
{
    public class StoreSettings
    {
        [JsonProperty("msaCountryCode")]
        public string MsaCountryCode { get; set; }

        [JsonProperty("id")]
        public uint Id { get; set; }
    }
}