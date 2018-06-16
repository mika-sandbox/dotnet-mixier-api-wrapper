using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Models;

namespace Frau.Clients.Users
{
    public class OAuthClient : ApiClient
    {
        public OAuthClient(MixerClient client) : base(client) { }

        public async Task<List<OAuthAuthorization>> AuthorizedAsync(uint userId)
        {
            return await MixerClient.GetAsync<List<OAuthAuthorization>>($"/users/{userId}/oauth/authorized");
        }

        public async Task<List<Models.OAuthClient>> ClientsAsync(uint userId)
        {
            return await MixerClient.GetAsync<List<Models.OAuthClient>>($"/users/{userId}/oauth/clients");
        }
    }
}