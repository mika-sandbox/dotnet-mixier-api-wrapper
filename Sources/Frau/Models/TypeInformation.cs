using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Frau.Models
{
    public class TypeInformation
    {
        [JsonProperty("aliases")]
        public List<string> Aliases { get; set; }

        [JsonProperty("backgroundUrl")]
        public string BackgroundUrl { get; set; }

        [JsonProperty("coverUrl")]
        public string CoverUrl { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("titles")]
        public List<TypeTitle> Titles { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("parent")]
        public string Parent { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("viewersCurrent")]
        public int ViewersCurrent { get; set; }

        [JsonProperty("online")]
        public int Online { get; set; }

        [JsonProperty("availableAt")]
        [JsonConverter(typeof(IsoDateTimeConverter))]
        public DateTime? AvailableAt { get; set; }
    }
}