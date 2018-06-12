using System.Threading.Tasks;

using Frau.Enum;
using Frau.Extensions;

namespace Frau.Clients.Authorization
{
    public class AuthorizedClient : ApiClient
    {
        public AuthorizedClient(MixerClient client) : base(client) { }

        public async Task RevokeAsync(uint client)
        {
            await MixerClient.DeleteAsync($"/oauth/authorized/{client}", MediaType.NoContent).Stay();
        }
    }
}