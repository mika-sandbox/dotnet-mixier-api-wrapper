using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Frau.Clients.Channels;
using Frau.Enum;
using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;
using Frau.Models.Flow;

using Newtonsoft.Json.Linq;

namespace Frau.Clients
{
    public class ChannelsClient : ApiClient
    {
        public AnalyticsClient Analytics { get; }
        public DiscordClient Discord { get; }
        public PartnershipClient Partnership { get; }

        public ChannelsClient(MixerClient client) : base(client)
        {
            Analytics = new AnalyticsClient(client);
            Discord = new DiscordClient(client);
            Partnership = new PartnershipClient(client);
        }

        public async Task<Pagenator<List<ChannelExtended>>> SearchAsync(string q, string scope, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("q", q),
                new KeyValuePair<string, string>("scope", scope)
            };
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<ChannelExtended>>>("/channels", parameters, false);
        }

        public async Task<ExpandedChannel> SingleAsync(string channelIdOrToken)
        {
            return await MixerClient.GetAsync<ExpandedChannel>($"/channnels/{channelIdOrToken}", null, false);
        }

        public async Task<ExpandedChannel> DetailsAsync(string channelIdOrToken)
        {
            return await MixerClient.GetAsync<ExpandedChannel>($"/channnels/{channelIdOrToken}/details", null, false);
        }

        public async Task<Channel> UpdateAsync(uint channelId, Channel channel)
        {
            return await MixerClient.PatchAsync<Channel>($"/channels/{channelId}", MediaType.Json, channel);
        }

        public async Task<ExpandedChannel> BadgeAsync(uint channelId, Stream badge)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("badge", badge)
            };

            return await MixerClient.PostAsync<ExpandedChannel>($"/channels/{channelId}/badge", MediaType.Multipart, parameters);
        }

        public async Task<Pagenator<List<UserWithChannel>>> FollowersAsync(uint channelId, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<UserWithChannel>>>($"/channels/{channelId}/follow", parameters);
        }

        public async Task<Follow> FollowAsync(uint channelId, uint user)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("user", user)
            };

            return await MixerClient.PostAsync<Follow>($"/channels/{channelId}/follow", MediaType.Json, parameters);
        }

        public async Task UnfollowAsync(uint channelId, uint user)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("user", user)
            };

            await MixerClient.DeleteAsync($"/channels/{channelId}/follow", MediaType.Json, parameters);
        }

        // Note: List<EmoticonPack> or EmoticonPack
        public async Task<object> EmoticonsAsync(uint channelId, uint? user = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            if (user.HasValue)
                parameters.Add(new KeyValuePair<string, string>("user", user.Value.ToString()));

            return await MixerClient.GetAsync($"/channels/{channelId}/emoticons", parameters);
        }

        public async Task<EmoticonGroup> ChangeEmoticonsAsync(uint channelId, List<object> patches)
        {
            return await MixerClient.PatchAsync<EmoticonGroup>($"/channels/{channelId}/emoticons", MediaType.Json, patches);
        }

        public async Task HosteeAsync(uint channelId)
        {
            await MixerClient.GetAsync<object>($"/channels/{channelId}/hostee");
        }

        public async Task<Channel> StartHostAsync(uint channelId, uint hostId)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("id", hostId)
            };

            return await MixerClient.PutAsync<Channel>($"/channels/{channelId}/hostee", MediaType.Json, parameters);
        }

        public async Task StopHostAsync(uint channelId)
        {
            await MixerClient.DeleteAsync($"/channels/{channelId}/hostee", MediaType.NoContent);
        }

        public async Task<List<ChannelAdvanced>> HostersAsync(uint channelId)
        {
            return await MixerClient.GetAsync<List<ChannelAdvanced>>($"/channels/{channelId}/hosters");
        }

        public async Task<ChannelPreferences> PreferencesAsync(uint channelId)
        {
            return await MixerClient.GetAsync<ChannelPreferences>($"/channels/{channelId}/preferences", null, false);
        }

        public async Task<ChannelPreferences> UpdatePreferencesAsync(uint channelId, ChannelPreferences channelPreferences)
        {
            return await MixerClient.PostAsync<ChannelPreferences>($"/channels/{channelId}/preferences", MediaType.Json, channelPreferences);
        }

        public async Task<List<Channel>> RelatedAsync(uint channelId, uint count)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("count", count.ToString())
            };

            return await MixerClient.GetAsync<List<Channel>>($"/channels/{channelId}/related", parameters, false);
        }

        public async Task<string> StreamKeyAsync(uint channelId)
        {
            var response = await MixerClient.GetAsync<object>($"/channels/{channelId}/streamKey") as JObject;
            return (string) response?["streamKey"];
        }

        public async Task<RelationShip> RelationshipAsync(uint channelId, uint user)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("user", user.ToString())
            };

            return await MixerClient.GetAsync<RelationShip>($"/channels/{channelId}/relationship", parameters, false);
        }

        public async Task<ExpandedChannel> UpdateThumbnailAsync(uint channelId, Stream thumbnail)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("thumbnai", thumbnail)
            };

            return await MixerClient.PostAsync<ExpandedChannel>($"/channels/{channelId}/thumbnail", MediaType.Multipart, parameters);
        }

        public async Task<Pagenator<List<UserWithGroups>>> UsersAsync(uint channelId, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<UserWithGroups>>>($"/channels/{channelId}/users", parameters, false);
        }

        public async Task<Pagenator<List<UserWithGroups>>> UsersByRoleAsync(uint channelId, string role, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<UserWithGroups>>>($"/channels/{channelId}/users/{role}", parameters, false);
        }

        public async Task<UserWithGroups> UpdateUserRoleAsync(uint channelId, uint userId, List<string> add = null, List<string> remove = null)
        {
            var parameters = new List<KeyValuePair<string, object>>();
            if (add != null)
                parameters.Add(new KeyValuePair<string, object>("add", add));
            if (remove != null)
                parameters.Add(new KeyValuePair<string, object>("remove", remove));

            return await MixerClient.PatchAsync<UserWithGroups>($"/channels/{channelId}/users/{userId}", MediaType.Json, parameters);
        }

        public async Task<DiscordBot> DiscordAsync(uint channelId)
        {
            return await MixerClient.GetAsync<DiscordBot>($"/channels/{channelId}/discord", null, false);
        }

        public async Task<DiscordBot> UpdateDiscordAsync(uint channelId, DiscordBot discordBot)
        {
            return await MixerClient.PutAsync<DiscordBot>($"/channels/{channelId}/discord", MediaType.Json, discordBot);
        }
    }
}