using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Extensions;
using Frau.Models;

namespace Frau.Clients
{
    public class AchievementsClient : ApiClient
    {
        internal AchievementsClient(MixerClient client) : base(client) { }

        public async Task<List<Achievement>> LisyAstnc()
        {
            return await MixerClient.GetAsync<List<Achievement>>("/achievements", null, false).Stay();
        }
    }
}