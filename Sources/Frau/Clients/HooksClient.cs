using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

namespace Frau.Clients
{
    public class HooksClient : ApiClient
    {
        public HooksClient(MixerClient client) : base(client) { }

        public async Task<List<Webhook>> ListAsync()
        {
            return await MixerClient.GetAsync<List<Webhook>>("/hooks");
        }

        public async Task CreateAsync(List<string> events, string url, string secret = null)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("events", events),
                new KeyValuePair<string, object>("kind", "web"),
                new KeyValuePair<string, object>("url", url)
            };
            if (!string.IsNullOrWhiteSpace(secret))
                parameters.Add(new KeyValuePair<string, object>("secret", secret));

            await MixerClient.PostAsync("/hooks", MediaType.Json, parameters);
        }

        public async Task<Webhook> ShowAsync(string hookId)
        {
            return await MixerClient.GetAsync<Webhook>($"/hooks/{hookId}", null, false);
        }

        public async Task<Webhook> DeactivateAsync(string hookId)
        {
            return await MixerClient.PostAsync<Webhook>($"/hooks/{hookId}/deactivate", MediaType.NoContent);
        }

        public async Task<Webhook> RenewAsync(string hookId)
        {
            return await MixerClient.PostAsync<Webhook>($"/hooks/{hookId}/renew", MediaType.NoContent);
        }
    }
}