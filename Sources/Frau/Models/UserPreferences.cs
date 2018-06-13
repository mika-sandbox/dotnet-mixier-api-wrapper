using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class UserPreferences
    {
        [JsonProperty("chat:sounds:html5")]
        public bool? ChatSoundsHtml5 { get; set; }

        [JsonProperty("chat:sounds:play")]
        public string ChatSoundsPlay { get; set; }

        [JsonProperty("chat:whispers")]
        public bool? ChatWhispers { get; set; }

        [JsonProperty("chat:timestamps")]
        public bool? ChatTimestamps { get; set; }

        [JsonProperty("chat:chromakey")]
        public bool? ChatChromakey { get; set; }

        [JsonProperty("chat:tagging")]
        public bool? ChatTagging { get; set; }

        [JsonProperty("chat:sounds:volume")]
        public int? ChatSoundsVolume { get; set; }

        [JsonProperty("chat:colors")]
        public bool? ChatColors { get; set; }

        [JsonProperty("chat:lurkmode")]
        public bool ChatLurkmode { get; set; }

        [JsonProperty("channel:notifications")]
        public ChannelNotifications ChannelNotifications { get; set; }

        [JsonProperty("channel:mature:allowed")]
        public bool? ChannelMatureAllowed { get; set; }

        [JsonProperty("channel:player:forceflash")]
        public bool? ChannelPlayerForceFlash { get; set; }

        [JsonProperty("chat:ignoredUsers")]
        public List<string> ChatIgnoredUsers { get; }

        [JsonProperty("channel:chatfilter:threshold")]
        public int ChannelChatfilterThreshold { get; set; }
    }
}