using System.Threading.Tasks;

using Frau.Enum;
using Frau.Models;

namespace Frau.Clients.Users
{
    public class NotificationsClient : ApiClient
    {
        public NotificationsClient(MixerClient client) : base(client) { }

        public async Task<NotificationPreference> PreferencesAsync(uint userId)
        {
            return await MixerClient.GetAsync<NotificationPreference>($"/users/{userId}/notifications/preferences");
        }

        public async Task<NotificationPreference> UpdatePreferencesAsync(uint userId, NotificationPreference notificationPreference)
        {
            return await MixerClient.PatchAsync<NotificationPreference>($"/users/{userId}/notifications/preferences", MediaType.Json, notificationPreference);
        }
    }
}