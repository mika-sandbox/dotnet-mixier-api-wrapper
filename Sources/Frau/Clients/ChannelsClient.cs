using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Frau.Clients.Channels;
using Frau.Enum;
using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;
using Frau.Models.Flow;

namespace Frau.Clients
{
    public class ChannelsClient : ApiClient
    {
        public AnalyticsClient Analytics { get; }

        public ChannelsClient(MixerClient client) : base(client)
        {
            Analytics = new AnalyticsClient(client);
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

        public async Task<List<ChannelAdvanced>> HostersAsync(uint channelId)
        {
            return await MixerClient.GetAsync<List<ChannelAdvanced>>($"/channels/{channelId}/hosters");
        }
    }
}