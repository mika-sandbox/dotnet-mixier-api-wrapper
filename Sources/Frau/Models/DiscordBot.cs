using System.Collections.Generic;

using Frau.Models.Internal;

using Newtonsoft.Json;

namespace Frau.Models
{
    public class DiscordBot
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("channelId")]
        public uint ChannelId { get; set; }

        [JsonProperty("guildId")]
        public uint GuildId { get; set; }

        [JsonProperty("inviteSetting")]
        public string InviteSetting { get; set; }

        [JsonProperty("inviteChannel")]
        public string InviteChannel { get; set; }

        [JsonProperty("liveUpdateState")]
        public bool LiveUpdateState { get; set; }

        [JsonProperty("liveChatChannel")]
        public string LiveChatChannel { get; set; }

        [JsonProperty("liveAnnounceChannel")]
        public string LiveAnnounceChannel { get; set; }

        [JsonProperty("syncEmoteRoles")]
        public List<uint> SyncEmoteRoles { get; set; }

        [JsonProperty("roles")]
        public List<BotRole> Roles { get; set; }
    }
}