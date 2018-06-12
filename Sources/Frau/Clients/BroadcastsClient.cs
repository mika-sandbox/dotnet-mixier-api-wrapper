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
            return await MixerClient.GetAsync<Broadcast>("/broadcasts/current").Stay();
        }

        public async Task<Broadcast> IdAsync(string uuid)
        {
            return await MixerClient.GetAsync<Broadcast>($"/broadcasts/{uuid}", null, false).Stay();
        }

#pragma warning disable CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます

        public async Task<object> IdManifestAsync(string type)
#pragma warning restore CS1998 // 非同期メソッドは、'await' 演算子がないため、同期的に実行されます
        {
            // TODO alias to /channels/{id}/manifest.{format}
            throw new NotImplementedException();
        }
    }
}