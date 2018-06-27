using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Frau.Clients
{
    public class CostreamsClient : ApiClient
    {
        public Costreams.ChannelsClient Channels { get; }

        public CostreamsClient(MixerClient client) : base(client)
        {
            Channels = new Costreams.ChannelsClient(client);
        }

        public async Task<Costream> ShowAsync(string costreamId)
        {
            return await MixerClient.GetAsync<Costream>($"/costreams/{costreamId}", null, false);
        }

        public async Task<Costream> UpdateAsync(string costreamId, Costream costream)
        {
            return await MixerClient.PatchAsync<Costream>($"/costreams/{costreamId}", MediaType.Json, costream);
        }

        public async Task InviteAsync(uint validFor, PlayerLayout playerLayout)
        {
            await MixerClient.PostAsync("/costreams/invite", MediaType.Json, playerLayout);
        }

        public async Task<Costream> CurrentAsync()
        {
            return await MixerClient.GetAsync<Costream>("/costreams/current");
        }

        public async Task DeleteAsync()
        {
            await MixerClient.DeleteAsync("/costreans/current", MediaType.NoContent);
        }
    }
}