using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class ErrorResponse
    {
        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }
    }
}