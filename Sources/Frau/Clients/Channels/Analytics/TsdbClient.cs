using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Models;

namespace Frau.Clients.Channels.Analytics
{
    public class TsdbClient : ApiClient
    {
        public TsdbClient(MixerClient client) : base(client) { }

        public async Task<List<ViewerAnalytic>> ViewersAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<ViewerAnalytic>>($"/channels/{channelId}/analytics/tsdb/viewers", parameters);
        }

        public async Task<List<ViewerMetricAnalytic>> ViewersMetricsAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<ViewerMetricAnalytic>>($"/channels/{channelId}/analytics/tsdb/viewersMetrics", parameters);
        }

        public async Task<List<IngestStreamAnalytic>> IngestStreamAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<IngestStreamAnalytic>>($"/channels/{channelId}/analytics/tsdb/ingestStream", parameters);
        }

        public async Task<List<StreamSessionsAnalytic>> StreamSessionsAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<StreamSessionsAnalytic>>($"/channels/{channelId}/analytics/tsdb/streamSessions", parameters);
        }

        public async Task<List<StreamHostsAnalytic>> StreamHostsAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<StreamHostsAnalytic>>($"/channels/{channelId}/analytics/tsdb/streamHosts", parameters);
        }

        public async Task<List<SubscriptionsAnalytic>> SubscriptionsAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<SubscriptionsAnalytic>>($"/channels/{channelId}/analytics/tsdb/subscriptions", parameters);
        }

        public async Task<List<FollowersAnalytic>> FollowersAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<FollowersAnalytic>>($"/channels/{channelId}/analytics/tsdb/followers", parameters);
        }

        public async Task<List<EmojiRankAnalytic>> EmojiUsageRanksAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<EmojiRankAnalytic>>($"/channels/{channelId}/analytics/tsdb/emojiUsageRanks", parameters);
        }

        public async Task<List<EmojiRankAnalytic>> EmojiUsageAsync(uint channelId, string emoji, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O")),
                new KeyValuePair<string, string>("emoji", emoji)
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<EmojiRankAnalytic>>($"/channels/{channelId}/analytics/tsdb/emojiUsage", parameters);
        }

        public async Task<List<GameRankAnalytic>> GameRanksGlobalAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<GameRankAnalytic>>($"/channels/{channelId}/analytics/tsdb/gameRanksGlobal", parameters);
        }

        public async Task<List<SubRevenueAnalytic>> SubRevenueAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<SubRevenueAnalytic>>($"/channels/{channelId}/analytics/tsdb/subRevenue", parameters);
        }

        public async Task<List<CPMAnalytic>> CpmAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<CPMAnalytic>>($"/channels/{channelId}/analytics/tsdb/cpm", parameters);
        }

        public async Task<List<ViewerSessionCountAnalytic>> ViewerSessionCountAsync(uint channelId, DateTime from, DateTime? to = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("from", from.ToString("O"))
            };
            if (to.HasValue)
                parameters.Add(new KeyValuePair<string, string>("to", to.Value.ToString("O")));

            return await MixerClient.GetAsync<List<ViewerSessionCountAnalytic>>($"/channels/{channelId}/analytics/tsdb/viewerSessionCount", parameters);
        }
    }
}