using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;

using Newtonsoft.Json.Linq;

namespace Frau.Clients
{
    public class SeenClient : ApiClient
    {
        public SeenClient(MixerClient client) : base(client)
        {
        }

        public async Task<bool> IsSeenAsync(string bucket, string thing, uint userId)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("user", userId.ToString())
            };

            var response = await MixerClient.GetAsync<object>($"/seen/{bucket}/{thing}", parameters) as JObject;
            return (bool) response?["seen"];
        }

        public async Task MarkAsSeen(string bucket, string thing, uint userId)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("user", userId.ToString())
            };
            await MixerClient.PutAsync($"/seen/{bucket}/{thing}", MediaType.Json, parameters);
        }
    }
}