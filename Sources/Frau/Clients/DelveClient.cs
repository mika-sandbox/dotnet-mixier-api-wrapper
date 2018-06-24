using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Models;
using Frau.Models.Flow;

namespace Frau.Clients
{
    public class DelveClient : ApiClient
    {
        public DelveClient(MixerClient client) : base(client) { }

        public async Task<DelveHome> HomeAsync(uint? userId = null, bool? hydrate = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            if (userId.HasValue)
                parameters.Add(new KeyValuePair<string, string>("userId", userId.Value.ToString()));
            if (hydrate.HasValue)
                parameters.Add(new KeyValuePair<string, string>("hydrate", hydrate.Value.ToString().ToLower()));

            return await MixerClient.GetAsync<DelveHome>("/delve/home", parameters);
        }

        public async Task<List<DelveMixPlayFilters>> MixPlayFiltersAsync()
        {
            return await MixerClient.GetAsync<List<DelveMixPlayFilters>>("/delve/mixPlayFilters", null, false);
        }
    }
}