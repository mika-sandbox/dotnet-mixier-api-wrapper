using System.Threading.Tasks;

using Frau.Enum;
using Frau.Extensions;
using Frau.Models.Flow;

namespace Frau.Clients.Authorization
{
    public class TokenClient : ApiClient
    {
        public TokenClient(MixerClient client) : base(client) { }

        public async Task<Introspect> IntrospectAsync()
        {
            return await MixerClient.PostAsync<Introspect>("/oauth/token/introspect", MediaType.NoContent, null, false).Stay();
        }
    }
}