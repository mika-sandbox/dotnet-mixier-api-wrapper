using System;

using Frau.Attributes;

namespace Frau.Enum
{
    [Flags]
    public enum Scopes : long
    {
        /// <summary>
        ///     achievement:view:self
        /// </summary>
        [Scope("achievement:view:self")]
        AchievementViewSelf = 1,

        /// <summary>
        ///     channel:analytics:self
        /// </summary>
        [Scope("channel:analytics:self")]
        ChannelAnalyticsSelf = 1L << 1,

        /// <summary>
        ///     channel:costream:self
        /// </summary>
        [Scope("channel:costream:self")]
        ChannelCostreamSelf = 1L << 2,

        /// <summary>
        ///     channel:deleteBanner:self
        /// </summary>
        [Scope("channel:deleteBanner:self")]
        ChannelDeleteBannerSelf = 1L << 3,

        /// <summary>
        ///     channel:details:self
        /// </summary>
        [Scope("channel:details:self")]
        ChannelDetailsSelf = 1L << 4,

        /// <summary>
        ///     channel:follow:self
        /// </summary>
        [Scope("channel:follow:self")]
        ChannelFollowSelf = 1L << 5,

        /// <summary>
        ///     channel:partnership
        /// </summary>
        [Scope("channel:partnership")]
        ChannelRelationship = 1L << 6,

        /// <summary>
        ///     channel:partnership:self
        /// </summary>
        [Scope("channel:partnership:self")]
        ChannelPartnershipSelf = 1L << 7,

        /// <summary>
        ///     channel:streamKey:self
        /// </summary>
        [Scope("channel:streamKey:self")]
        ChannelStreamKeySelf = 1L << 8,

        /// <summary>
        ///     channel:teststream:view:self
        /// </summary>
        [Scope("channel:teststream:view:self")]
        ChannelTeststreamViewSelf = 1L << 9,

        /// <summary>
        ///     channel:update:self
        /// </summary>
        [Scope("channel:update:self")]
        ChannelUpdateSelf = 1L << 10,

        /// <summary>
        ///     chat:bypass_catbot
        /// </summary>
        [Scope("chat:bypass_catbot")]
        ChatBypassCatbot = 1L << 11,

        /// <summary>
        ///     chat:bypass_filter
        /// </summary>
        [Scope("chat:bypass_filter")]
        ChatBypassFilter = 1L << 12,

        /// <summary>
        ///     chat:bypass_links
        /// </summary>
        [Scope("chat:bypass_links")]
        ChatBypassLinks = 1L << 13,

        /// <summary>
        ///     chat:bypass_slowchat
        /// </summary>
        [Scope("chat:bypass_slowchat")]
        ChatBypassSlowchat = 1L << 14,

        /// <summary>
        ///     chat:change_ban
        /// </summary>
        [Scope("chat:change_ban")]
        ChatChangeBan = 1L << 15,

        /// <summary>
        ///     chat:change_role
        /// </summary>
        [Scope("chat:change_role")]
        ChatChangeRole = 1L << 16,

        /// <summary>
        ///     chat:chat
        /// </summary>
        [Scope("chat:chat")]
        ChatChat = 1L << 17,

        /// <summary>
        ///     chat:clear_messages
        /// </summary>
        [Scope("chat:clear_messages")]
        ChatClearMessages = 1L << 18,

        /// <summary>
        ///     chat:connect
        /// </summary>
        [Scope("chat:connect")]
        ChatConnect = 1L << 19,

        /// <summary>
        ///     chat:edit_options
        /// </summary>
        [Scope("chat:edit_options")]
        ChatEditOptions = 1L << 20,

        /// <summary>
        ///     chat:giveaway_start
        /// </summary>
        [Scope("chat:giveaway_start")]
        ChatGiveawayStart = 1L << 21,

        /// <summary>
        ///     chat:poll_start
        /// </summary>
        [Scope("chat:poll_start")]
        ChatPollStart = 1L << 22,

        /// <summary>
        ///     chat:poll_vote
        /// </summary>
        [Scope("chat:poll_vote")]
        ChatPollVote = 1L << 23,

        /// <summary>
        ///     chat:purge
        /// </summary>
        [Scope("chat:purge")]
        CharPurge = 1L << 24,

        /// <summary>
        ///     chat:remove_message
        /// </summary>
        [Scope("chat:remove_message")]
        ChatRemoveMessage = 1L << 25,

        /// <summary>
        ///     chat:timeout
        /// </summary>
        [Scope("chat:timeout")]
        ChatTimeout = 1L << 26,

        /// <summary>
        ///     chat:view_deleted
        /// </summary>
        [Scope("chat:view_deleted")]
        ChatViewDeleted = 1L << 27,

        /// <summary>
        ///     chat:whisper
        /// </summary>
        [Scope("chat:whisper")]
        ChatWhisper = 1L << 28,

        /// <summary>
        ///     interactive:manage:self
        /// </summary>
        [Scope("interactive:manage:self")]
        InteractiveManageSelf = 1L << 29,

        /// <summary>
        ///     interactive:robot:self
        /// </summary>
        [Scope("interactive:robot:self")]
        InteractiveRobotSelf = 1L << 30,

        /// <summary>
        ///     invoice:view:self
        /// </summary>
        [Scope("invoice:view:self")]
        InvoiceViewSelf = 1L << 31,

        /// <summary>
        ///     log:view:self
        /// </summary>
        [Scope("log:view:self")]
        LogViewSelf = 1L << 32,

        /// <summary>
        ///     notification:update:self
        /// </summary>
        [Scope("notification:update:self")]
        NotificationUpdateSelf = 1L << 33,

        /// <summary>
        ///     notification:view:self
        /// </summary>
        [Scope("notification:view:self")]
        NotificationViewSelf = 1L << 34,

        /// <summary>
        ///     recording:manage:self
        /// </summary>
        [Scope("recording:manage:self")]
        RecordingManageSelf = 1L << 35,

        /// <summary>
        ///     redeemable:create:self
        /// </summary>
        [Scope("redeemable:create:self")]
        RedeemableCreateSelf = 1L << 36,

        /// <summary>
        ///     redeemable:redeem:self
        /// </summary>
        [Scope("redeemable:redeem:self")]
        RedeemableRedeemSelf = 1L << 37,

        /// <summary>
        ///     redeemable:view:self
        /// </summary>
        [Scope("redeemable:view:self")]
        RedeemableViewSelf = 1L << 38,

        /// <summary>
        ///     resource:find:self
        /// </summary>
        [Scope("resource:find:self")]
        ResourceFindSelf = 1L << 39,

        /// <summary>
        ///     subscription:cancel:self
        /// </summary>
        [Scope("subscription:cancel:self")]
        SubscriptionCancelSelf = 1L << 40,

        /// <summary>
        ///     subscription:create:self
        /// </summary>
        [Scope("subscription:create:self")]
        SubscriptionCreateSelf = 1L << 41,

        /// <summary>
        ///     subscription:renew:self
        /// </summary>
        [Scope("subscription:renew:self")]
        SubscriptionRenewSelf = 1L << 42,

        /// <summary>
        ///     subscription:view:self
        /// </summary>
        [Scope("subscription:view:self")]
        SubscriptionViewSelf = 1L << 43,

        /// <summary>
        ///     team:administer
        /// </summary>
        [Scope("team:administer")]
        TeamAdminister = 1L << 44,

        /// <summary>
        ///     team:manage:self
        /// </summary>
        [Scope("team:manage:self")]
        TeamManageSelf = 1L << 45,

        /// <summary>
        ///     transaction:cancel:self
        /// </summary>
        [Scope("transaction:cancel:self")]
        TransactionCancelSelf = 1L << 46,

        /// <summary>
        ///     transaction:view:self
        /// </summary>
        [Scope("transaction:view:self")]
        TransactionViewSelf = 1L << 47,

        /// <summary>
        ///     user:analytics:self
        /// </summary>
        [Scope("user:analytics:self")]
        UserAnalyticsSelf = 1L << 48,

        /// <summary>
        ///     user:details
        /// </summary>
        [Scope("user:details:self")]
        UserDetailsSelf = 1L << 49,

        /// <summary>
        ///     user:getDiscordInvite:self
        /// </summary>
        [Scope("user:getDiscordInvite:self")]
        UserGetDiscordInviteSelf = 1L << 50,

        /// <summary>
        ///     user:log:self
        /// </summary>
        [Scope("user:log:self")]
        UserLogSelf = 1L << 51,

        /// <summary>
        ///     user:notification:self
        /// </summary>
        [Scope("user:notification:self")]
        UserNotificationSelf = 1L << 52,

        /// <summary>
        ///     user:seen:self
        /// </summary>
        [Scope("user:seen:self")]
        UserSeenSelf = 1L << 53,

        /// <summary>
        ///     user:update:self
        /// </summary>
        [Scope("user:update:self")]
        UserUpdateSelf = 1L << 54,

        /// <summary>
        ///     user:updatePassword:self
        /// </summary>
        [Scope("user:updatePassword:self")]
        UserUpdatePasswordSelf = 1L << 55
    }
}