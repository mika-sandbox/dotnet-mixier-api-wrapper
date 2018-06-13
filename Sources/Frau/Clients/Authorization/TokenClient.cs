using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Extensions;
using Frau.Models.Flow;

namespace Frau.Clients.Authorization
{
    public class TokenClient : ApiClient
    {
        public TokenClient(MixerClient client) : base(client) { }

        public async Task<Introspect> IntrospectAsync(string token)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("token", token)
            };
            return await MixerClient.PostAsync<Introspect>("/oauth/token/introspect", MediaType.Json, parameters, false).Stay();
        }
    }
}