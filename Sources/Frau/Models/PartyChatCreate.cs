using Newtonsoft.Json;

namespace Frau.Models
{
    public class PartyChatCreate
    {
        [JsonProperty("protocolVersion")]
        public int ProtocolVersion { get; set; }

        [JsonProperty("deviceUUID")]
        public string DeviceUuid { get; set; }

        [JsonProperty("webRtcDtlsCertificateAlgorithm")]
        public string WebRtcDtlsCertificateAlgorithm { get; set; }

        [JsonProperty("webRtcDtlsCertificateThumbprint")]
        public string WebRtcDtlsCertificateThumbprint { get; set; }

        [JsonProperty("webRtcIceUfrag")]
        public string WebRtcIceUfrag { get; set; }

        [JsonProperty("webRtcIcePwd")]
        public string WebRtcIcePwd { get; set; }
    }
}