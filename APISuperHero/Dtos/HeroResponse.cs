using System.Text.Json.Serialization;

namespace APISuperHero.Dtos
{
    public class HeroResponse
    {
        [JsonIgnore]
        public string? Response { get; set; }
        [JsonIgnore]
        public string? Id { get; set; }

        public string? Nome { get; set; }
        public string? Inteligencia { get; set; }
        public string? Força { get; set; }
        public string? Velocidade { get; set; }
        public string? Resistencia { get; set; }
        public string? Poder { get; set; }
        public string? Combate { get; set; }
    }
}
