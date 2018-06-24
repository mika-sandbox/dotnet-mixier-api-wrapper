using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

namespace Frau.Clients
{
    public class ConfettiClient : ApiClient
    {
        public ConfettiClient(MixerClient client) : base(client) { }

        public async Task<Confetti> CreateAsync(Confetti confetti)
        {
            return await MixerClient.PutAsync<Confetti>("/confetti", MediaType.Json, confetti);
        }

        public async Task<Confetti> ShowAsync(uint confettiId)
        {
            return await MixerClient.GetAsync<Confetti>($"/confetti/{confettiId}", null, false);
        }

        public async Task<Confetti> UpdateAsync(uint confettiId, Confetti confetti)
        {
            return await MixerClient.PatchAsync<Confetti>($"/confetti/{confettiId}", MediaType.Json, confetti);
        }

        public async Task DeleteAsync(uint confettiId)
        {
            await MixerClient.DeleteAsync($"/confetti/{confettiId}", MediaType.NoContent);
        }
    }
}