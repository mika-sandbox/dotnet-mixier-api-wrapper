using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

using Newtonsoft.Json.Linq;

namespace Frau.Clients.Channels
{
    public class DiscordClient : ApiClient
    {
        public DiscordClient(MixerClient client) : base(client) { }

        public async Task<List<DiscordChannel>> ChannelsAsync(uint channelId)
        {
            return await MixerClient.GetAsync<List<DiscordChannel>>($"/channels/{channelId}/discord/channels");
        }

        public async Task<List<DiscordRole>> RolesAsync(uint channelId)
        {
            return await MixerClient.GetAsync<List<DiscordRole>>($"/channels/{channelId}/discord/roles", null, false);
        }

        public async Task InvitesAsync(uint channelId, uint user)
        {
            var parameters = new List<KeyValuePair<string, string>>
            {
                new KeyValuePair<string, string>("user", user.ToString())
            };
            await MixerClient.GetAsync<object>($"/channels/{channelId}/discord/invite", parameters, false);
        }

        public async Task<string> InviteAsync(uint channel, uint user)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("user", user)
            };

            var response = await MixerClient.PostAsync<object>($"/channels/{channel}/discord/invite", MediaType.Json, parameters, false) as JObject;
            return (string) response?["redirectUri"];
        }
    }
}