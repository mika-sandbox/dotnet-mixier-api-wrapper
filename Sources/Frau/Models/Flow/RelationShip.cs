using Newtonsoft.Json;

namespace Frau.Models.Flow
{
    public class RelationShip
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("status")]
        public RelationShipStatus Status { get; set; }
    }
}