using System.Text.Json.Serialization;

namespace APISuperHero.Models
{
    public class ImageModel
    {
        [JsonPropertyName("response")]
        public string? Response { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("url")]
        public string? Url { get; set; }
    }
}
