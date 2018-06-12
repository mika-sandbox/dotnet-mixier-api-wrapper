using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}