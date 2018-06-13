using System.Collections.Generic;

using Frau.Attributes;
using Frau.Enum;

namespace Frau.Extensions
{
    public static class ScopesExtension
    {
        public static string GetAttributeValue(this Scopes obj)
        {
            return obj.GetAttribute<ScopeAttribute>().Str;
        }

        public static string ToScopeString(this Scopes obj)
        {
            var scopes = new List<string>();

            // Auto-generated, do not edit this
            /*
             * var sb = new StringBuilder();
             * foreach (var value in System.Enum.GetValues(typeof(Scopes))) {
             *     sb.AppendLine($"if ((obj & Scopes.{value}) == Scopes.{value})");
             *     sb.AppendLine($"    scopes.Add(Scopes.{value}.GetAttributeValue());");
             * }
             * sb.ToString().Dump();
             */
            if ((obj & Scopes.AchievementViewSelf) == Scopes.AchievementViewSelf)
                scopes.Add(Scopes.AchievementViewSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelAnalyticsSelf) == Scopes.ChannelAnalyticsSelf)
                scopes.Add(Scopes.ChannelAnalyticsSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelCostreamSelf) == Scopes.ChannelCostreamSelf)
                scopes.Add(Scopes.ChannelCostreamSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelDeleteBannerSelf) == Scopes.ChannelDeleteBannerSelf)
                scopes.Add(Scopes.ChannelDeleteBannerSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelDetailsSelf) == Scopes.ChannelDetailsSelf)
                scopes.Add(Scopes.ChannelDetailsSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelFollowSelf) == Scopes.ChannelFollowSelf)
                scopes.Add(Scopes.ChannelFollowSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelRelationship) == Scopes.ChannelRelationship)
                scopes.Add(Scopes.ChannelRelationship.GetAttributeValue());
            if ((obj & Scopes.ChannelPartnershipSelf) == Scopes.ChannelPartnershipSelf)
                scopes.Add(Scopes.ChannelPartnershipSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelStreamKeySelf) == Scopes.ChannelStreamKeySelf)
                scopes.Add(Scopes.ChannelStreamKeySelf.GetAttributeValue());
            if ((obj & Scopes.ChannelTeststreamViewSelf) == Scopes.ChannelTeststreamViewSelf)
                scopes.Add(Scopes.ChannelTeststreamViewSelf.GetAttributeValue());
            if ((obj & Scopes.ChannelUpdateSelf) == Scopes.ChannelUpdateSelf)
                scopes.Add(Scopes.ChannelUpdateSelf.GetAttributeValue());
            if ((obj & Scopes.ChatBypassCatbot) == Scopes.ChatBypassCatbot)
                scopes.Add(Scopes.ChatBypassCatbot.GetAttributeValue());
            if ((obj & Scopes.ChatBypassFilter) == Scopes.ChatBypassFilter)
                scopes.Add(Scopes.ChatBypassFilter.GetAttributeValue());
            if ((obj & Scopes.ChatBypassLinks) == Scopes.ChatBypassLinks)
                scopes.Add(Scopes.ChatBypassLinks.GetAttributeValue());
            if ((obj & Scopes.ChatBypassSlowchat) == Scopes.ChatBypassSlowchat)
                scopes.Add(Scopes.ChatBypassSlowchat.GetAttributeValue());
            if ((obj & Scopes.ChatChangeBan) == Scopes.ChatChangeBan)
                scopes.Add(Scopes.ChatChangeBan.GetAttributeValue());
            if ((obj & Scopes.ChatChangeRole) == Scopes.ChatChangeRole)
                scopes.Add(Scopes.ChatChangeRole.GetAttributeValue());
            if ((obj & Scopes.ChatChat) == Scopes.ChatChat)
                scopes.Add(Scopes.ChatChat.GetAttributeValue());
            if ((obj & Scopes.ChatClearMessages) == Scopes.ChatClearMessages)
                scopes.Add(Scopes.ChatClearMessages.GetAttributeValue());
            if ((obj & Scopes.ChatConnect) == Scopes.ChatConnect)
                scopes.Add(Scopes.ChatConnect.GetAttributeValue());
            if ((obj & Scopes.ChatEditOptions) == Scopes.ChatEditOptions)
                scopes.Add(Scopes.ChatEditOptions.GetAttributeValue());
            if ((obj & Scopes.ChatGiveawayStart) == Scopes.ChatGiveawayStart)
                scopes.Add(Scopes.ChatGiveawayStart.GetAttributeValue());
            if ((obj & Scopes.ChatPollStart) == Scopes.ChatPollStart)
                scopes.Add(Scopes.ChatPollStart.GetAttributeValue());
            if ((obj & Scopes.ChatPollVote) == Scopes.ChatPollVote)
                scopes.Add(Scopes.ChatPollVote.GetAttributeValue());
            if ((obj & Scopes.CharPurge) == Scopes.CharPurge)
                scopes.Add(Scopes.CharPurge.GetAttributeValue());
            if ((obj & Scopes.ChatRemoveMessage) == Scopes.ChatRemoveMessage)
                scopes.Add(Scopes.ChatRemoveMessage.GetAttributeValue());
            if ((obj & Scopes.ChatTimeout) == Scopes.ChatTimeout)
                scopes.Add(Scopes.ChatTimeout.GetAttributeValue());
            if ((obj & Scopes.ChatViewDeleted) == Scopes.ChatViewDeleted)
                scopes.Add(Scopes.ChatViewDeleted.GetAttributeValue());
            if ((obj & Scopes.ChatWhisper) == Scopes.ChatWhisper)
                scopes.Add(Scopes.ChatWhisper.GetAttributeValue());
            if ((obj & Scopes.InteractiveManageSelf) == Scopes.InteractiveManageSelf)
                scopes.Add(Scopes.InteractiveManageSelf.GetAttributeValue());
            if ((obj & Scopes.InteractiveRobotSelf) == Scopes.InteractiveRobotSelf)
                scopes.Add(Scopes.InteractiveRobotSelf.GetAttributeValue());
            if ((obj & Scopes.InvoiceViewSelf) == Scopes.InvoiceViewSelf)
                scopes.Add(Scopes.InvoiceViewSelf.GetAttributeValue());
            if ((obj & Scopes.LogViewSelf) == Scopes.LogViewSelf)
                scopes.Add(Scopes.LogViewSelf.GetAttributeValue());
            if ((obj & Scopes.NotificationUpdateSelf) == Scopes.NotificationUpdateSelf)
                scopes.Add(Scopes.NotificationUpdateSelf.GetAttributeValue());
            if ((obj & Scopes.NotificationViewSelf) == Scopes.NotificationViewSelf)
                scopes.Add(Scopes.NotificationViewSelf.GetAttributeValue());
            if ((obj & Scopes.RecordingManageSelf) == Scopes.RecordingManageSelf)
                scopes.Add(Scopes.RecordingManageSelf.GetAttributeValue());
            if ((obj & Scopes.RedeemableCreateSelf) == Scopes.RedeemableCreateSelf)
                scopes.Add(Scopes.RedeemableCreateSelf.GetAttributeValue());
            if ((obj & Scopes.RedeemableRedeemSelf) == Scopes.RedeemableRedeemSelf)
                scopes.Add(Scopes.RedeemableRedeemSelf.GetAttributeValue());
            if ((obj & Scopes.RedeemableViewSelf) == Scopes.RedeemableViewSelf)
                scopes.Add(Scopes.RedeemableViewSelf.GetAttributeValue());
            if ((obj & Scopes.ResourceFindSelf) == Scopes.ResourceFindSelf)
                scopes.Add(Scopes.ResourceFindSelf.GetAttributeValue());
            if ((obj & Scopes.SubscriptionCancelSelf) == Scopes.SubscriptionCancelSelf)
                scopes.Add(Scopes.SubscriptionCancelSelf.GetAttributeValue());
            if ((obj & Scopes.SubscriptionCreateSelf) == Scopes.SubscriptionCreateSelf)
                scopes.Add(Scopes.SubscriptionCreateSelf.GetAttributeValue());
            if ((obj & Scopes.SubscriptionRenewSelf) == Scopes.SubscriptionRenewSelf)
                scopes.Add(Scopes.SubscriptionRenewSelf.GetAttributeValue());
            if ((obj & Scopes.SubscriptionViewSelf) == Scopes.SubscriptionViewSelf)
                scopes.Add(Scopes.SubscriptionViewSelf.GetAttributeValue());
            if ((obj & Scopes.TeamAdminister) == Scopes.TeamAdminister)
                scopes.Add(Scopes.TeamAdminister.GetAttributeValue());
            if ((obj & Scopes.TeamManageSelf) == Scopes.TeamManageSelf)
                scopes.Add(Scopes.TeamManageSelf.GetAttributeValue());
            if ((obj & Scopes.TransactionCancelSelf) == Scopes.TransactionCancelSelf)
                scopes.Add(Scopes.TransactionCancelSelf.GetAttributeValue());
            if ((obj & Scopes.TransactionViewSelf) == Scopes.TransactionViewSelf)
                scopes.Add(Scopes.TransactionViewSelf.GetAttributeValue());
            if ((obj & Scopes.UserAnalyticsSelf) == Scopes.UserAnalyticsSelf)
                scopes.Add(Scopes.UserAnalyticsSelf.GetAttributeValue());
            if ((obj & Scopes.UserDetailsSelf) == Scopes.UserDetailsSelf)
                scopes.Add(Scopes.UserDetailsSelf.GetAttributeValue());
            if ((obj & Scopes.UserGetDiscordInviteSelf) == Scopes.UserGetDiscordInviteSelf)
                scopes.Add(Scopes.UserGetDiscordInviteSelf.GetAttributeValue());
            if ((obj & Scopes.UserLogSelf) == Scopes.UserLogSelf)
                scopes.Add(Scopes.UserLogSelf.GetAttributeValue());
            if ((obj & Scopes.UserNotificationSelf) == Scopes.UserNotificationSelf)
                scopes.Add(Scopes.UserNotificationSelf.GetAttributeValue());
            if ((obj & Scopes.UserSeenSelf) == Scopes.UserSeenSelf)
                scopes.Add(Scopes.UserSeenSelf.GetAttributeValue());
            if ((obj & Scopes.UserUpdateSelf) == Scopes.UserUpdateSelf)
                scopes.Add(Scopes.UserUpdateSelf.GetAttributeValue());
            if ((obj & Scopes.UserUpdatePasswordSelf) == Scopes.UserUpdatePasswordSelf)
                scopes.Add(Scopes.UserUpdatePasswordSelf.GetAttributeValue());

            return string.Join(" ", scopes);
        }
    }
}