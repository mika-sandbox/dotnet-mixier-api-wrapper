using Newtonsoft.Json;

namespace Frau.Models
{
    public class ChannelPreferences
    {
        [JsonProperty("sharetext")]
        public string Sharetext { get; set; }

        [JsonProperty("channel:links:allowed")]
        public bool? ChannelLinksAllowed { get; set; }

        [JsonProperty("channel:links:clickable")]
        public bool? ChannelLinksClickable { get; set; }

        [JsonProperty("channel:slowchat")]
        public int? ChannelSlowchat { get; set; }

        [JsonProperty("channel:notify:directPurchaseMessage")]
        public string ChannelNotifyDirectPurchaseMessage { get; set; }

        [JsonProperty("channel:notify:subscribemessage")]
        public string ChannelNotifySubscribeMessage { get; set; }

        [JsonProperty("channel:notify:subscribe")]
        public bool? ChannelNotifySubscribe { get; set; }

        [JsonProperty("channel:notify:followmessage")]
        public string ChannelNotifyFollowMessage { get; set; }

        [JsonProperty("channel:notify:follow")]
        public bool? ChannelNotifyFollow { get; set; }

        [JsonProperty("channel:notify:hostedBy")]
        public string ChannelNotifyHostedBy { get; set; }

        [JsonProperty("channel:notify:hosting")]
        public string ChannelNotifyHosting { get; set; }

        [JsonProperty("channel:partner:submail")]
        public string ChannelPartnerSubmail { get; set; }

        [JsonProperty("channel:player:muteOwn")]
        public bool? ChannelPlayerMuteOwn { get; set; }

        [JsonProperty("channel:tweet:enabled")]
        public bool? ChannelTweetEnabled { get; set; }

        [JsonProperty("channel:tweet:body")]
        public string ChannelTweetBody { get; set; }

        [JsonProperty("hypezone:allow")]
        public bool HypezoneAllow { get; set; }

        [JsonProperty("hosting:allow")]
        public bool HostingAllow { get; set; }

        [JsonProperty("mixer:featured:allow")]
        public bool MixerFeaturedAllow { get; set; }

        [JsonProperty("costream:allow")]
        public bool CostreamAllow { get; set; }

        [JsonProperty("channel:offline:autoplayVod")]
        public bool ChannelOfflineAutoplayVod { get; set; }
    }
}