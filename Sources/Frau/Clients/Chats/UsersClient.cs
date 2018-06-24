using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;
using Frau.Models.Flow;

namespace Frau.Clients.Chats
{
    public class UsersClient : ApiClient
    {
        public UsersClient(MixerClient client) : base(client) { }

        public async Task<ChatUser> RetrieveUserAsync(uint channelId, uint userId)
        {
            return await MixerClient.GetAsync<ChatUser>($"/chats/{channelId}/users/{userId}");
        }

        public async Task<Pagenator<List<ChatUser>>> SearchAsync(uint channelId, string username, SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("username", username)
            };
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<Pagenator<List<ChatUser>>>($"/chats/{channelId}/users/search");
        }
    }
}