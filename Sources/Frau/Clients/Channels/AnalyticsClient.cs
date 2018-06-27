using Frau.Clients.Channels.Analytics;

// ReSharper disable UnusedAutoPropertyAccessor.Global

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