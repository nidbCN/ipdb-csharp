using System.Text.Json.Serialization;

namespace ipdb
{
    /**
     * @copyright IPIP.net
     */
    public class MetaData
    {
        [JsonPropertyName("build")]
        public int Build;

        [JsonPropertyName("ip_version")]
        public int IPVersion;

        [JsonPropertyName("node_count")]
        public int nodeCount;

        [JsonPropertyName("languages")]
        public Dictionary<string, int> Languages;

        [JsonPropertyName("fields")]
        public string[] Fields;

        [JsonPropertyName("total_size")]
        public int totalSize;
    }
}
