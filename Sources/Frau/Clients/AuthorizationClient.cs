using System.Collections.Generic;
using System.Threading.Tasks;

using Frau.Clients.Authorization;
using Frau.Enum;
using Frau.Extensions;
using Frau.Models;
using Frau.Models.Flow;

namespace Frau.Clients
{
    public class AuthorizationClient : ApiClient
    {
        public AuthorizedClient Authorized { get; }
        public ClientsClient Clients { get; }
        public TokenClient Token { get; }
        public ShortcodeClient Shortcode { get; }

        public AuthorizationClient(MixerClient client) : base(client)
        {
            Authorized = new AuthorizedClient(client);
            Clients = new ClientsClient(client);
            Token = new TokenClient(client);
            Shortcode = new ShortcodeClient(client);
        }

        public async Task<OAuthClient> ClientsAsync(OAuthClient oAuthClient)
        {
            return await MixerClient.PostAsync<OAuthClient>("/oauth/clients", MediaType.Json, oAuthClient).Stay();
        }

        public async Task<Tokens> TokenAsync(string grantType, string refreshToken, string code, string redirectUri)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("grant_type", grantType),
                new KeyValuePair<string, object>("client_id", MixerClient.ClientId),
                new KeyValuePair<string, object>("client_secret", MixerClient.ClientSecret)
            };
            if (!string.IsNullOrWhiteSpace(refreshToken))
                parameters.Add(new KeyValuePair<string, object>("refresh_token", refreshToken));
            if (!string.IsNullOrWhiteSpace(code))
                parameters.Add(new KeyValuePair<string, object>("code", code));
            if (!string.IsNullOrWhiteSpace(redirectUri))
                parameters.Add(new KeyValuePair<string, object>("redirect_uri", redirectUri));

            return await MixerClient.PostAsync<Tokens>("/oauth/token", MediaType.Json, parameters, false).Stay();
        }

        public async Task<Shortcode> ShortcodeAsync(string clientId, string clientSecret, string scope)
        {
            var parameters = new List<KeyValuePair<string, object>>
            {
                new KeyValuePair<string, object>("client_id", clientId),
                new KeyValuePair<string, object>("scope", scope)
            };
            if (!string.IsNullOrWhiteSpace(clientSecret))
                parameters.Add(new KeyValuePair<string, object>("client_secret", clientSecret));

            return await MixerClient.PostAsync<Shortcode>("/oauth/shortcode", MediaType.Json, parameters, false).Stay();
        }
    }
}