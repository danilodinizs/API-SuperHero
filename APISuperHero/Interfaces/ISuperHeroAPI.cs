using APISuperHero.Dtos;
using APISuperHero.Models;

namespace APISuperHero.Interfaces
{
    public interface ISuperHeroAPI
    {
        Task<ResponseGenerico<HeroModel>> BuscarHeroPorId(string id);
        Task<ResponseGenerico<HeroModel>> BuscarHeroPorNome(string nome);
        Task<ResponseGenerico<ImageModel>> BuscarHeroPorIdImage(string id);
    }
}
