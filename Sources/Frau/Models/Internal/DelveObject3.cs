using Newtonsoft.Json;

namespace Frau.Models.Internal
{
    public class DelveObject3 : DelveObjectBase
    {
        [JsonProperty("coverUrl")]
        public string CoverUrl { get; set; }
    }
}