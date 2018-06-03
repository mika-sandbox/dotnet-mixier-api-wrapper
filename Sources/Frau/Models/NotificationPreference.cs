using System;
using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class NotificationPreference
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("alllowsEmailMarketing")]
        public bool AlllowsEmailMarketing { get; set; }

        [JsonProperty("notifyFollower")]
        public List<string> NotifyFollower { get; set; }

        [JsonProperty("notifySubscriber")]
        public List<string> NotifySubscriber { get; set; }

        [JsonProperty("liveOnByDefault")]
        public List<string> LiveOnByDefault { get; set; }

        [JsonProperty("lastRead")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime LastRead { get; set; }

        [JsonProperty("health")]
        public Health Health { get; set; }

        [JsonProperty("liveNotifications")]
        public List<LiveNotification> LiveNotifications { get; set; }

        [JsonProperty("transports")]
        public List<object> Transports { get; set; }
    }
}