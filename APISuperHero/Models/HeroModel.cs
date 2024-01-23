using System.Text.Json.Serialization;

namespace APISuperHero.Models
{
    public class HeroModel
    {
        [JsonPropertyName("response")]
        public string? Response { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("intelligence")]
        public string? Inteligencia { get; set; }

        [JsonPropertyName("strength")]
        public string? Força { get; set; }

        [JsonPropertyName("speed")]
        public string? Velocidade { get; set; }

        [JsonPropertyName("durability")]
        public string? Resistencia { get; set; }

        [JsonPropertyName("power")]
        public string? Poder { get; set; }

        [JsonPropertyName("combat")]
        public string? Combate { get; set; }
    }
}
