using System.Threading.Tasks;

using Frau.Extensions;
using Frau.Models.Flow;

namespace Frau.Clients.Authorization
{
    public class ShortcodeClient : ApiClient
    {
        public ShortcodeClient(MixerClient client) : base(client) { }

        public async Task<Shortcode> CheckAsync(string handle)
        {
            return await MixerClient.GetAsync<Shortcode>($"/oauth/shortcode/check/{handle}", null, false).Stay();
        }
    }
}