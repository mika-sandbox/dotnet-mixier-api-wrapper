using System;
using System.Threading.Tasks;

using Frau.Extensions;
using Frau.Models;

namespace Frau.Clients
{
    public class BroadcastsClient : ApiClient
    {
        public BroadcastsClient(MixerClient client) : base(client) { }

        public async Task<Broadcast> CurrentAsync()
        {
            return await MixerClient.GetAsync<Broadcast>("/broadcasts/current", MixerClient.EmptyParameter).Stay();
        }

        public async Task<Broadcast> IdAsync(string uuid)
        {
            return await MixerClient.GetAsync<Broadcast>($"/broadcasts/{uuid}", MixerClient.EmptyParameter, false).Stay();
        }

        public async Task<object> IdManifestAsync(string type)
        {
            // TODO alias to /channels/{id}/manifest.{format}
            throw new NotImplementedException();
        }
    }
}