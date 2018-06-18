using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

namespace Frau.Clients
{
    public class InvoicesClient : ApiClient
    {
        public InvoicesClient(MixerClient client) : base(client) { }

        public async Task<Invoice> SingleAsync(uint invoice)
        {
            return await MixerClient.GetAsync<Invoice>($"/invoices/{invoice}");
        }

        public async Task CaptureAsync(uint invoice, string nonce, string gateway)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("nonce", nonce),
                new KeyValuePair<string, object>("gateway", gateway)
            };

            await MixerClient.PostAsync($"/invoices/{invoice}/capture", MediaType.Json, parameters);
        }
    }
}