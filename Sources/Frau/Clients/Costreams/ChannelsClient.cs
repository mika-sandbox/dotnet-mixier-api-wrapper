using System.Threading.Tasks;

using Frau.Enum;

namespace Frau.Clients.Costreams
{
    public class ChannelsClient : ApiClient
    {
        public ChannelsClient(MixerClient client) : base(client) { }

        public async Task DeleteAsync(string costreamId, uint channelId)
        {
            await MixerClient.DeleteAsync($"/costreams/{costreamId}/channels/{channelId}", MediaType.NoContent);
        }
    }
}