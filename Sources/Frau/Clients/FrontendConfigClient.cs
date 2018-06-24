using System.Threading.Tasks;

using Frau.Models;

namespace Frau.Clients
{
    public class FrontendConfigClient : ApiClient
    {
        public FrontendConfigClient(MixerClient client) : base(client) { }

        public async Task<FrontendConfig> ShowAsync()
        {
            return await MixerClient.GetAsync<FrontendConfig>("/frontendConfig", null, false);
        }
    }
}