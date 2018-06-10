namespace Frau.Clients
{
    public class ApiClient
    {
        protected MixerClient MixerClient { get; }

        protected ApiClient(MixerClient client)
        {
            MixerClient = client;
        }
    }
}