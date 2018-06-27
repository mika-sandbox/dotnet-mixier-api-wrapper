using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Frau.Clients.Users;
using Frau.Enum;
using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;
using Frau.Models.Flow;

using FlowedFrontendVersion = Frau.Models.Flow.FrontendVersion;
using OAuthClient = Frau.Clients.Users.OAuthClient;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Frau.Clients
{
    public class UsersClient : ApiClient
    {
        public NotificationsClient Notifications { get; }
        public OAuthClient OAuthClient { get; }
        public TeamsClient Teams { get; }

        public UsersClient(MixerClient client) : base(client)
        {
            Notifications = new NotificationsClient(client);
            OAuthClient = new OAuthClient(client);
            Teams = new TeamsClient(client);
        }

        public async Task<PrivatePopulatedUser> CurrentAsync()
        {
            return await MixerClient.GetAsync<PrivatePopulatedUser>("/users/current");
        }

        public async Task<Pagenator<List<UserWithChannel>>> SearchAsync(string query, SearchParameter searchParameter = null)

        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("query", query)
            };
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<UserWithChannel>>>("/users/search", parameters, false);
        }

        public async Task<UserWithChannelExtended> ShowAsync(uint userId)
        {
            return await MixerClient.GetAsync<UserWithChannelExtended>($"/users/{userId}");
        }

        public async Task<PrivateUser> UpdateAsync(uint userId, PrivateUser obj)
        {
            return await MixerClient.PatchAsync<PrivateUser>($"/users/{userId}", MediaType.Json, obj);
        }

        public async Task<List<AchievementEarning>> ShowUserAchievements(uint userId)
        {
            return await MixerClient.GetAsync<List<AchievementEarning>>($"/users/{userId}/achievements");
        }

        public async Task<Stream> ShowAvatarAsync(uint userId, uint? w = null, uint? h = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            if (w.HasValue)
                parameters.Add(new KeyValuePair<string, string>("w", w.Value.ToString()));
            if (h.HasValue)
                parameters.Add(new KeyValuePair<string, string>("h", h.Value.ToString()));

            return await MixerClient.GetAsync($"/users/{userId}/avatar", parameters, false);
        }

        public async Task<User> UpdateAvatarAsync(uint userId, Stream avatar)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("avatar", avatar)
            };

            return await MixerClient.PostAsync<User>($"/users/{userId}/avatar", MediaType.Multipart, parameters);
        }

        public async Task<User> DeleteAvayarAsync(uint userId)
        {
            return await MixerClient.DeleteAsync<User>($"/users/{userId}/avatar", MediaType.NoContent);
        }

        public async Task<Pagenator<List<ChannelAdvanced>>> FollowsAsync(uint userId, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<ChannelAdvanced>>>($"/users/{userId}/follows", parameters, false);
        }

#pragma warning disable CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます

        public async Task<FlowedFrontendVersion> FrontendVersionAsync(uint userId)
#pragma warning restore CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます
        {
            throw new NotImplementedException();
        }

        public async Task<Pagenator<List<Invoice>>> InvoicesAsync(uint userId, SearchParameter searchParameter)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<Invoice>>>($"/users/{userId}/follows", parameters, false);
        }

        public async Task<List<OAuthLink>> LinksAsync(uint userId)
        {
            return await MixerClient.GetAsync<List<OAuthLink>>($"/users/{userId}/links");
        }

        public async Task<Pagenator<List<UserLog>>> LogAsync(uint userId, SearchParameter searchParameter)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<UserLog>>>($"/users/{userId}/log", parameters, false);
        }

        public async Task<Pagenator<List<Notification>>> NotificationsAsync(uint userId, SearchParameter searchParameter)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<Notification>>>($"/users/{userId}/notifications", parameters, false);
        }

        public async Task<UserPreferences> PreferencesAsync(uint userId)
        {
            return await MixerClient.GetAsync<UserPreferences>($"/users/{userId}/preferences", null, false);
        }

        public async Task<UserPreferences> UpdatePreferencesAsync(uint userId, UserPreferences preferences)
        {
            return await MixerClient.PostAsync<UserPreferences>($"/users/{userId}/preferences", MediaType.Json, preferences);
        }

        public async Task<Pagenator<List<RecurringPaymentExpanded>>> RecurringPaymentsAsync(uint userId, SearchParameter searchParameter)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<RecurringPaymentExpanded>>>($"/users/{userId}/recurringPayments", parameters);
        }

        public async Task<Pagenator<List<ExpandedRedeemable>>> RedeemablesAsync(uint userId, SearchParameter searchParameter)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<ExpandedRedeemable>>>($"/users/{userId}/redeemables", parameters, false);
        }

        public async Task<List<Resource>> ResourcesAsync(uint userId)
        {
            return await MixerClient.GetAsync<List<Resource>>($"/users/{userId}/resources");
        }

        public async Task<List<Session>> SessionsAsync(uint userId)
        {
            return await MixerClient.GetAsync<List<Session>>($"/users/{userId}/sessions");
        }

        public async Task<Pagenator<List<SubscriptionWithGroup>>> SubscriptionsAsync(uint userId, SearchParameter searchParameter)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<SubscriptionWithGroup>>>($"/users/{userId}/subscriptions", parameters);
        }

        public async Task<List<TeamMembershipExpanded>> TeamsAsync(uint userId)
        {
            return await MixerClient.GetAsync<List<TeamMembershipExpanded>>($"/users/{userId}/teams");
        }

        public async Task<UserWithChannelExtended> DetailsAsync(uint userId)
        {
            return await MixerClient.GetAsync<UserWithChannelExtended>($"/users/{userId}/details", null, false);
        }

        public async Task<RecentlyViewedChannels> RecentlyViewedChannels(uint userId, uint? page = null, uint? limit = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            if (page.HasValue)
                parameters.Add(new KeyValuePair<string, string>("page", page.Value.ToString()));
            if (limit.HasValue)
                parameters.Add(new KeyValuePair<string, string>("limit", limit.Value.ToString()));

            return await MixerClient.GetAsync<RecentlyViewedChannels>($"/users/{userId}/recentlyViewedChannels", parameters, false);
        }
    }
}