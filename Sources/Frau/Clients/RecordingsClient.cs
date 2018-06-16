using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Enum;
using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;

namespace Frau.Clients
{
    public class RecordingsClient : ApiClient
    {
        public RecordingsClient(MixerClient client) : base(client) { }

        public async Task<List<Recording>> ListAsync(SearchParameter searchParameter = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            searchParameter?.AddTo(parameters);

            return await MixerClient.GetAsync<List<Recording>>("/recordings", parameters, false);
        }

        public async Task<Recording> ShowAsync(uint recordingId, uint? user = null)
        {
            var parameters = new List<KeyValuePair<string, string>>();
            if (user.HasValue)
                parameters.Add(new KeyValuePair<string, string>("user", user.Value.ToString()));

            return await MixerClient.GetAsync<Recording>($"/recordings/{recordingId}", parameters, false);
        }

        public async Task<Recording> UpdateAsync(uint recordingId, Recording recording)
        {
            return await MixerClient.PatchAsync<Recording>($"/recordings/{recordingId}", MediaType.Json, recording);
        }

        public async Task DeleteAsync(uint recordingId)
        {
            await MixerClient.DeleteAsync($"/recordings/{recordingId}", MediaType.NoContent);
        }

        public async Task MarkAsSeenAsync(uint recording, uint userId, uint duration)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("user", userId),
                new KeyValuePair<string, object>("duration", duration)
            };

            await MixerClient.PostAsync($"/recordings/{recording}/seen", MediaType.Json, parameters);
        }

        // Note: check work
        public async Task DeleteChatAsync(uint recording, List<string> splice)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("splice", splice)
            };

            await MixerClient.DeleteAsync($"/recordings/{recording}/chat", MediaType.Json, parameters);
        }
    }
}