using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Models;

namespace Frau.Clients
{
    public class TranscodesClient : ApiClient
    {
        public TranscodesClient(MixerClient client) : base(client) { }

        public async Task<List<ExpandedTranscodingProfile>> ListAsync()
        {
            return await MixerClient.GetAsync<List<ExpandedTranscodingProfile>>("/transcodes");
        }
    }
}