using Newtonsoft.Json;

namespace Frau.Models
{
    public class IngestStreamAnalytic
    {
        [JsonProperty("ingest_id")]
        public uint IngestId { get; set; }

        [JsonProperty("channel_id")]
        public uint ChannelId { get; set; }

        [JsonProperty("subscribed_dist_nodes")]
        public uint SubscribedDistNodes { get; set; }

        [JsonProperty("video_packet_loss")]
        public int VideoPacketLoss { get; set; }

        [JsonProperty("video_packet_recovered")]
        public int VideoPacketRecovered { get; set; }

        [JsonProperty("video_avg_recovery_delay")]
        public uint VideoAvgRecoveryDelay { get; set; }

        [JsonProperty("video_avg_nack_delay")]
        public uint VideoAvgNackDelay { get; set; }

        [JsonProperty("video_bitrate")]
        public uint VideoBitrate { get; set; }

        [JsonProperty("video_jitter_buffer_size")]
        public uint VideoJitterBufferSize { get; set; }

        [JsonProperty("audiovo_packet_loss")]
        public int AudiovoPacketLoss { get; set; }

        [JsonProperty("audiov_packet_recovered")]
        public int AudiovPacketRecovered { get; set; }

        [JsonProperty("audiov_avg_recovery_delay")]
        public uint AudiovAvgRecoveryDelay { get; set; }

        [JsonProperty("audio_avg_nack_delay")]
        public uint AudioAvgNackDelay { get; set; }

        [JsonProperty("audiov_bitrate")]
        public uint AudiovBitrate { get; set; }

        [JsonProperty("audioo_jitter_buffer_size")]
        public uint AudiooJitterBufferSize { get; set; }
    }
}