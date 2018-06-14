using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

using Frau.Clients;
using Frau.Enum;
using Frau.Exceptions;
using Frau.Extensions;
using Frau.Helpers;
using Frau.Models.Flow;

using Newtonsoft.Json;

using Parameters = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, object>>;

namespace Frau
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class MixerClient
    {
        private const string BaseUrl = "https://mixer.com/api/v1";
        private readonly HttpClient _httpClient;

        // ReSharper disable once InconsistentNaming
        private readonly MethodInfo DeserializeObject;

        internal string ClientId { get; }
        internal string ClientSecret { get; }

        /// <summary>
        ///     現在使用しているアクセストークン
        /// </summary>
        public string AccessToken { get; internal set; }

        public string RefreshToken { get; internal set; }

        public AchievementsClient Achievements { get; }
        public BroadcastsClient Broadcasts { get; }
        public AuthorizationClient OAuth { get; }
        public FrontendVersionsClient FrontendVersions { get; }
        public UsersClient Users { get; }

        public MixerClient(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;

            _httpClient = new HttpClient();
            DeserializeObject = typeof(JsonConvert).GetMethods(BindingFlags.Public | BindingFlags.Static)
                                                   .Where(w => w.Name == "DeserializeObject")
                                                   .First(w => w.IsGenericMethod && w.IsGenericMethodDefinition);

            Achievements = new AchievementsClient(this);
            Broadcasts = new BroadcastsClient(this);
            FrontendVersions = new FrontendVersionsClient(this);
            OAuth = new AuthorizationClient(this);
            Users = new UsersClient(this);
        }

        internal async Task<T> GetAsync<T>(string url, List<KeyValuePair<string, string>> parameters = null, bool requireAuth = true) where T : class
        {
            ProcessAuthHeader(requireAuth);
            url = BaseUrl + url;

            if (parameters != null && parameters.Any())
                url += "?" + string.Join("&", parameters.Select(w => $"{w.Key}={Uri.EscapeDataString(w.Value)}"));
            var response = await _httpClient.GetAsync(url).Stay();
            await HandleErrors(response);

            if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(Pagenator<>))
                return await ProcessResponseWithHeader<T>(response);
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync().Stay());
        }

        internal async Task PostAsync(string url, MediaType mediaType, object parameters = null, bool requireAuth = true)
        {
            await SendAsync(HttpMethod.Post, url, mediaType, parameters, requireAuth).Stay();
        }

        internal async Task<T> PostAsync<T>(string url, MediaType mediaType, object parameters = null, bool requireAuth = true) where T : class
        {
            return await SendAsync<T>(HttpMethod.Post, url, mediaType, parameters, requireAuth).Stay();
        }

        internal async Task PutAsync(string url, MediaType mediaType, object parameters = null, bool requireAuth = true)
        {
            await SendAsync(HttpMethod.Put, url, mediaType, parameters, requireAuth).Stay();
        }

        internal async Task<T> PutAsync<T>(string url, MediaType mediaType, object parameters = null, bool requireAuth = true) where T : class
        {
            return await SendAsync<T>(HttpMethod.Put, url, mediaType, parameters, requireAuth).Stay();
        }

        internal async Task DeleteAsync(string url, MediaType mediaType, object parameters = null, bool requireAuth = true)
        {
            await SendAsync(HttpMethod.Delete, url, mediaType, parameters, requireAuth).Stay();
        }

        internal async Task<T> DeleteAsync<T>(string url, MediaType mediaType, object parameters = null, bool requireAuth = true) where T : class
        {
            return await SendAsync<T>(HttpMethod.Delete, url, mediaType, parameters, requireAuth).Stay();
        }

        private async Task SendAsync(HttpMethod method, string url, MediaType mediaType, object parameters = null, bool requireAuth = true)
        {
            ProcessAuthHeader(requireAuth);

            var content = PrepareHttpContent(parameters, mediaType);
            var response = await _httpClient.SendAsync(new HttpRequestMessage(method, BaseUrl + url) {Content = content}).Stay();
            await HandleErrors(response);
        }

        private async Task<T> SendAsync<T>(HttpMethod method, string url, MediaType mediaType, object parameters = null, bool requireAuth = true)
            where T : class
        {
            ProcessAuthHeader(requireAuth);

            var content = PrepareHttpContent(parameters, mediaType);
            var response = await _httpClient.SendAsync(new HttpRequestMessage(method, BaseUrl + url) {Content = content}).Stay();
            await HandleErrors(response);

            if (typeof(T).IsGenericType && typeof(T).GetGenericTypeDefinition() == typeof(Pagenator<>))
                return await ProcessResponseWithHeader<T>(response);
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

        private static HttpContent PrepareHttpContent(object parameters, MediaType mediaType)
        {
            HttpContent content;
            switch (mediaType)
            {
                case MediaType.Json:
                    // object (as a Model) and List<KeyValuePair<string, object>> support.
                    object obj;
                    if (parameters is Parameters params1)
                    {
                        var dictionary = new Dictionary<string, string>();
                        params1.ForEach(w => dictionary.Add(w.Key, w.Value.ToString()));
                        obj = dictionary;
                    }
                    else
                    {
                        obj = parameters;
                    }
                    content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
                    break;

                case MediaType.Multipart:
                    if (parameters is Parameters params2)
                    {
                        content = new MultipartFormDataContent();
                        foreach (var parameter in params2)
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
                    }
                    else
                    {
                        throw new NotSupportedException($"Multipart supports {typeof(List<KeyValuePair<string, object>>)} only");
                    }
                    break;

                case MediaType.NoContent:
                    // No Content
                    content = null;
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(mediaType), mediaType, null);
            }
            return content;
        }

        private static async Task HandleErrors(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
                return;
            var content = await response.Content.ReadAsStringAsync();
            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (Exception e)
            {
                throw new FrauException(content, response.StatusCode.ToString(), e);
            }
        }

        private async Task<T> ProcessResponseWithHeader<T>(HttpResponseMessage response) where T : class
        {
            // Create Pagenator instance
            var pagenator = Activator.CreateInstance<T>() as IPagenator;
            if (pagenator == null)
                throw new NullReferenceException();

            // Deserialize JSON object
            var content = await response.Content.ReadAsStringAsync();
            var jsonObj = DeserializeObject.MakeGenericMethod(typeof(T).GenericTypeArguments[0]).Invoke(null, new object[] {content});
            pagenator.Body = jsonObj;

            // Parse "Link" header
            var linkHeader = response.Headers.GetValues("link").FirstOrDefault();
            var linking = LinkHeaderParser.Parse(linkHeader);
            pagenator.First = linking.FirstOrDefault(w => w.Rel == "first")?.Uri;
            pagenator.Next = linking.FirstOrDefault(w => w.Rel == "next")?.Uri;
            pagenator.Prev = linking.FirstOrDefault(w => w.Rel == "prev")?.Uri;
            pagenator.Last = linking.FirstOrDefault(w => w.Rel == "last")?.Uri;

            // Parse "X-Total-Count" header
            var totalCount = response.Headers.GetValues("x-total-count").FirstOrDefault();
            pagenator.Total = string.IsNullOrWhiteSpace(totalCount) ? 0 : uint.Parse(totalCount);
            return pagenator as T;
        }
    }
}