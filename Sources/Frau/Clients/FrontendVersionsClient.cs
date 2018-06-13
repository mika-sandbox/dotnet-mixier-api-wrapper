using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Models;

namespace Frau.Clients
{
    public class FrontendVersionsClient : ApiClient
    {
        public FrontendVersionsClient(MixerClient client) : base(client) { }

        public async Task<List<FrontendVersion>> ShowAsync(int query)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("query", query.ToString())
            };
            return await MixerClient.GetAsync<List<FrontendVersion>>("/frontendVersions", parameters);
        }
    }
}