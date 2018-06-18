using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

namespace Frau.Clients
{
    public class ResourcesClient : ApiClient
    {
        public ResourcesClient(MixerClient client) : base(client) { }

        public async Task<Resource> RetrievesAsync(uint resource)
        {
            return await MixerClient.GetAsync<Resource>($"/resources/{resource}");
        }

        public async Task DeleteAsync(uint resource)
        {
            await MixerClient.DeleteAsync($"/resources/{resource}", MediaType.Json);
        }
    }
}