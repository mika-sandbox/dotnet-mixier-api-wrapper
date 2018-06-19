using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Clients.Channels;
using Frau.Enum;
using Frau.Extensions;
using Frau.Models;
using Frau.Models.Bucket;
using Frau.Models.Flow;

namespace Frau.Clients
{
    public class ChannelsClient : ApiClient
    {
        public AnalyticsClient Analytics { get; }

        protected ChannelsClient(MixerClient client) : base(client)
        {
            Analytics = new AnalyticsClient(client);
        }
    }
}