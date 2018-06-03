using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

using Frau.Extensions;

using Newtonsoft.Json.Linq;

namespace Frau
{
    public class MixerClient
    {
        private readonly HttpClient _httpClient;
        internal string ClientId { get; }
        internal string ClientSecret { get; }
        internal static List<KeyValuePair<string, string>> EmptyParameter => new List<KeyValuePair<string, string>>();

        /// <summary>
        ///     現在使用しているアクセストークン
        /// </summary>
        public string AccessToken { get; internal set; }

        public MixerClient(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;

            _httpClient = new HttpClient();
        }

        internal async Task<T> GetAsync<T>(string url, List<KeyValuePair<string, string>> parameters, bool requireAuth = true)
        {
            return (await GetAsync(url, parameters, requireAuth).Stay()).ToObject<T>();
        }

        internal async Task<JObject> GetAsync(string url, List<KeyValuePair<string, string>> parameters, bool requireAuth = true)
        {
            if (requireAuth)
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            if (parameters.Any())
                url += "?" + string.Join("&", parameters.Select(w => $"{w.Key}={Uri.EscapeDataString(w.Value)}"));
            var response = await _httpClient.GetAsync(url).Stay();
            HandleErrors(response);

            return JObject.Parse(await response.Content.ReadAsStringAsync().Stay());
        }

        internal async Task<T> PostAsync<T>(string url, List<KeyValuePair<string, string>> parameters, bool requireAuth = true)
        {
            return (await PostAsync(url, parameters, requireAuth).Stay()).ToObject<T>();
        }

        internal async Task<JObject> PostAsync(string url, List<KeyValuePair<string, string>> parameters, bool requireAuth = true)
        {
            if (requireAuth)
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            var content = new FormUrlEncodedContent(parameters);
            var response = await _httpClient.PostAsync(url, content).Stay();
            HandleErrors(response);
            return JObject.Parse(await response.Content.ReadAsStringAsync().Stay());
        }

        private static void HandleErrors(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;
            response.EnsureSuccessStatusCode();
        }
    }
}