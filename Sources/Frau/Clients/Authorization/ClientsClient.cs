using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Extensions;
using Frau.Models;

namespace Frau.Clients.Authorization
{
    public class ClientsClient : ApiClient
    {
        public ClientsClient(MixerClient client) : base(client) { }

        public async Task<OAuthClient> ShowAsync(uint client)
        {
            return await MixerClient.GetAsync<OAuthClient>($"/oauth/clients/{client}").Stay();
        }

        public async Task<OAuthClient> UpdateAsync(uint client, OAuthClient oAuthClient)
        {
            return await MixerClient.PutAsync<OAuthClient>($"/oauth/clients/{client}", MediaType.Json, oAuthClient).Stay();
        }

        public async Task DeleteAsync(uint client)
        {
            await MixerClient.DeleteAsync($"/oauth/clients/{client}", MediaType.NoContent).Stay();
        }

        public async Task<OAuthClient> CreateLogoAsync(uint client, Stream logo)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("logo", logo)
            };
            return await MixerClient.PostAsync<OAuthClient>($"/oauth/clients/{client}", MediaType.Json, parameters).Stay();
        }
    }
}