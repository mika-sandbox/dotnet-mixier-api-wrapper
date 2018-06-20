using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;
using Frau.Models.Flow;

namespace Frau.Clients.Channels
{
    public class PartnershipClient : ApiClient
    {
        public PartnershipClient(MixerClient client) : base(client)
        {
            //
        }

        public async Task<PartnershipApp> AppAsync(uint channelId)
        {
            return await MixerClient.GetAsync<PartnershipApp>($"/channels/{channelId}/partnership/app");
        }

        public async Task<PartnershipApp> CreateAppAsync(uint channelId, string firstName, string lastName, string app)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("firstName", firstName),
                new KeyValuePair<string, string>("lastName", lastName),
                new KeyValuePair<string, string>("app", app)
            };

            return await MixerClient.PostAsync<PartnershipApp>($"/channels/{channelId}/partnership/app", MediaType.Json, parameters);
        }

        public async Task<RedeemableExtended> CodesAsync(uint channelId)
        {
            return await MixerClient.GetAsync<RedeemableExtended>($"/channels/{channelId}/partnershi/codes");
        }

        public async Task VerifyAsync(uint channelId)
        {
            await MixerClient.GetAsync<object>($"/channels/{channelId}/partnershi/verify");
        }
    }
}