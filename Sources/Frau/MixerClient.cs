using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

using Frau.Clients;
using Frau.Enum;
using Frau.Extensions;

using Newtonsoft.Json;

using Parameters = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;

namespace Frau
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MixerClient
    {
        private const string BaseUrl = "https://mixer.com/api/v1";
        private readonly HttpClient _httpClient;
        internal string ClientId { get; }
        internal string ClientSecret { get; }
        internal static List<KeyValuePair<string, string>> EmptyParameter => new List<KeyValuePair<string, string>>();

        /// <summary>
        ///     現在使用しているアクセストークン
        /// </summary>
        public string AccessToken { get; internal set; }

        public AchievementsClient Achievements { get; }

        public MixerClient(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;

            _httpClient = new HttpClient();

            Achievements = new AchievementsClient(this);
        }

        internal async Task<T> GetAsync<T>(string url, List<KeyValuePair<string, string>> parameters, bool requireAuth = true)
        {
            ProcessAuthHeader(requireAuth);
            url = BaseUrl + url;

            if (parameters.Any())
                url += "?" + string.Join("&", parameters.Select(w => $"{w.Key}={Uri.EscapeDataString(w.Value)}"));
            var response = await _httpClient.GetAsync(url).Stay();
            HandleErrors(response);

            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().Stay());
        }

        internal async Task<T> PostAsync<T>(string url, Parameters parameters, MediaType mediaType, bool requireAuth = true)
        {
            return await SendAsync<T>(HttpMethod.Post, url, parameters, mediaType, requireAuth).Stay();
        }

        internal async Task<T> PutAsync<T>(string url, Parameters parameters, MediaType mediaType, bool requireAuth = true)
        {
            return await SendAsync<T>(HttpMethod.Put, url, parameters, mediaType, requireAuth).Stay();
        }

        internal async Task<T> DeleteAsync<T>(string url, Parameters parameters, MediaType mediaType, bool requireAuth = true)
        {
            return await SendAsync<T>(HttpMethod.Delete, url, parameters, mediaType, requireAuth).Stay();
        }

        private async Task<T> SendAsync<T>(HttpMethod method, string url, Parameters parameters, MediaType mediaType, bool requireAuth = true)
        {
            ProcessAuthHeader(requireAuth);

            HttpContent content;
            switch (mediaType)
            {
                case MediaType.Json:
                    content = new StringContent(JsonConvert.SerializeObject(parameters), Encoding.UTF8, "application/json");
                    break;

                case MediaType.Multipart:
                    content = new MultipartFormDataContent();
                    foreach (var parameter in parameters)
                        if (parameter.Value is Stream stream)
                        {
                            var binary = new StreamContent(stream);
                            binary.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                            binary.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data");
                            ((MultipartFormDataContent) content).Add(binary, parameter.Key);
                        }
                        else
                        {
                            ((MultipartFormDataContent) content).Add(new StringContent(parameter.Value.ToString()), parameter.Key);
                        }
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(mediaType), mediaType, null);
            }

            var response = await _httpClient.SendAsync(new HttpRequestMessage(method, BaseUrl + url) {Content = content}).Stay();
            HandleErrors(response);

            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().Stay());
        }

        private void ProcessAuthHeader(bool requireAuth)
        {
            if (!string.IsNullOrWhiteSpace(AccessToken))
            {
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            }
            else
            {
                if (requireAuth)
                    throw new AuthenticationException("Invalid AccessToken.");
            }
        }

        private static void HandleErrors(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;
            response.EnsureSuccessStatusCode();
        }
    }
}