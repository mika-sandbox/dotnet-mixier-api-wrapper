using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;
using Frau.Models.Flow;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Frau.Clients
{
    public class ChatsClient : ApiClient
    {
        public Chats.UsersClient Users { get; }

        public ChatsClient(MixerClient client) : base(client)
        {
            Users = new Chats.UsersClient(client);
        }

        public async Task<ChatPrepare> PrepareAsync(uint channelId)
        {
            return await MixerClient.GetAsync<ChatPrepare>($"/chats/{channelId}", null, false);
        }

        public async Task<ChatPrepare> JoinIfNotBigEventAsync(uint channelId)
        {
            return await MixerClient.GetAsync<ChatPrepare>($"/chats/{channelId}/joinIfNotBigEvent", null, false);
        }

        public async Task<ChatPrepare> AnonymousAsync(uint channelId)
        {
            return await MixerClient.GetAsync<ChatPrepare>($"/chats/{channelId}/anonymous", null, false);
        }

        public async Task<Pagenator<List<ChatUser>>> FriendsAsync(uint channelId, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<ChatUser>>>($"/chats/{channelId}/friends", parameters);
        }

        public async Task<Pagenator<List<ChatUser>>> UsersAsync(uint channelId, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<ChatUser>>>($"/chats/{channelId}/users", parameters, false);
        }

        public async Task<object> HistoryAsync(uint channelId, bool? enhanced = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            if (enhanced.HasValue)
                parameters.Add(new KeyValuePair<string, string>("enhanced", enhanced.Value.ToString().ToLower()));

            return await MixerClient.GetAsync<object>($"/chats/{channelId}/history", parameters, false);
        }
    }
}