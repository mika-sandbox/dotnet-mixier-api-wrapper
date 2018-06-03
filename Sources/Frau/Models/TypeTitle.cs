using Newtonsoft.Json;

namespace Frau.Models
{
    public class TypeTitle
    {
        [JsonProperty("aumId")]
        public string AumId { get; set; }

        [JsonProperty("kglId")]
        public string KglId { get; set; }

        [JsonProperty("processName")]
        public string ProcessName { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("titleId")]
        public int TitleId { get; set; }
    }
}