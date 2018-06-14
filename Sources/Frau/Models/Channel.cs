using Newtonsoft.Json;

namespace Frau.Models
{
    public class Channel : TimeStamped
    {
        [JsonProperty("id")]
        public uint Id { get; set; }

        [JsonProperty("userId")]
        public uint UserId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("online")]
        public bool Online { get; set; }

        [JsonProperty("featured")]
        public bool Featured { get; set; }

        [JsonProperty("featureLevel")]
        public uint FeatureLevel { get; set; }

        [JsonProperty("partnered")]
        public bool Partnered { get; set; }

        [JsonProperty("transcodingProfileId")]
        public uint? TranscodingProfileId { get; set; }

        [JsonProperty("suspended")]
        public bool Suspended { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("audience")]
        public string Audience { get; set; }

        [JsonProperty("viewersTotal")]
        public uint ViewersTotal { get; set; }

        [JsonProperty("viewersCurrent")]
        public uint ViewersCurrent { get; set; }

        [JsonProperty("numFollowers")]
        public uint NumFollowers { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("typeId")]
        public uint? TypeId { get; set; }

        [JsonProperty("interactive")]
        public bool Interactive { get; set; }

        [JsonProperty("interactiveGameId")]
        public uint? InteractiveGameId { get; set; }

        [JsonProperty("ftl")]
        public int Ftl { get; set; }

        [JsonProperty("hasVod")]
        public bool HasVod { get; set; }

        [JsonProperty("languageId")]
        public string LanguageId { get; set; }

        [JsonProperty("coverId")]
        public uint? CoverId { get; set; }

        [JsonProperty("thumbnailId")]
        public uint? ThumbnailId { get; set; }

        [JsonProperty("badgeId")]
        public uint? BadgeId { get; set; } /* Nullable? */

        [JsonProperty("bannerUrl")]
        public string BannerUrl { get; set; }

        [JsonProperty("hosteeId")]
        public uint? HosteeId { get; set; } /* Nullable? */

        [JsonProperty("hasTranscodes")]
        public bool HasTranscodes { get; set; }

        [JsonProperty("vodsEnabled")]
        public bool VodsEnabled { get; set; }

        [JsonProperty("costreamId")]
        public string CostreamId { get; set; }
    }
}