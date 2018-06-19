using Frau.Clients.Channels.Analytics;

namespace Frau.Clients.Channels
{
    public class AnalyticsClient : ApiClient
    {
        public TsdbClient Tsdb { get; }

        public AnalyticsClient(MixerClient client) : base(client)
        {
            Tsdb = new TsdbClient(client);
        }
    }
}