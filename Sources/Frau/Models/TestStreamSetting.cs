using System;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class TestStreamSetting
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        [JsonProperty("hoursQuota")]
        public int HoursQuota { get; set; }

        [JsonProperty("hoursRemaining")]
        public int HoursRemaining { get; set; }

        [JsonProperty("hoursResetIntervalInDays")]
        public uint HoursResetIntervalInDays { get; set; }

        [JsonProperty("hoursLastReset")]
        public DateTime? HoursLastReset { get; set; }
    }
}