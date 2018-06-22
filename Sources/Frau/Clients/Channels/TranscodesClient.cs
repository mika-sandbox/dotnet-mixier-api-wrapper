using System.Threading.Tasks;

using Frau.Enum;

namespace Frau.Clients.Channels
{
    public class TranscodesClient : ApiClient
    {
        public TranscodesClient(MixerClient client) : base(client) { }

        public async Task UnlockAsync(uint channelId)
        {
            await MixerClient.PostAsync($"/channels/{channelId}/transcodes/unlock", MediaType.NoContent);
        }
    }
}