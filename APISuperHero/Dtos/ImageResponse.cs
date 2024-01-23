using System.Text.Json.Serialization;

namespace APISuperHero.Dtos
{
    public class ImageResponse
    {
        [JsonIgnore]
        public string? Response { get; set; }

        [JsonIgnore]
        public string?Id { get; set; }

        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}
