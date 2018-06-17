using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

namespace Frau.Clients
{
    public class RedeemablesClient : ApiClient
    {
        public RedeemablesClient(MixerClient client) : base(client) { }

        public async Task<Invoice> CreateAsync(string type)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("type", type)
            };

            return await MixerClient.PostAsync<Invoice>("redeemables", MediaType.Json, parameters);
        }

        public async Task<Redeemable> RetrieveAsync(uint redeemable)
        {
            return await MixerClient.GetAsync<Redeemable>($"/redeemables/{redeemable}");
        }

        public async Task<Invoice> RedeemAsync(string code, uint? channel)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("code", code)
            };
            if (channel.HasValue)
                parameters.Add(new KeyValuePair<string, object>("channel", channel.Value.ToString()));

            return await MixerClient.PostAsync<Invoice>("/redeemables/redeem", MediaType.Json, parameters);
        }
    }
}