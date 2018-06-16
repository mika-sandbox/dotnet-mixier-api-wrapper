using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Models;

namespace Frau.Clients.Users
{
    public class TeamsClient : ApiClient
    {
        public TeamsClient(MixerClient client) : base(client) { }

        public async Task<uint> LimitAsync(uint userId)
        {
            return (uint) await MixerClient.GetAsync<object>($"/users/{userId}/teams/limit", null, false);
        }

        public async Task<User> PrimaryAsync(uint userId, uint teamId)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("teamId", teamId.ToString())
            };

            return await MixerClient.GetAsync<User>($"/users/{userId}/teams/primary", parameters);
        }
    }
}