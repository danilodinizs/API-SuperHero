using APISuperHero.Dtos;
using APISuperHero.Models;

namespace APISuperHero.Interfaces
{
    public interface IHeroService
    {
        Task<ResponseGenerico<HeroResponse>> BuscarHeroPorId(string id);
        Task<ResponseGenerico<HeroResponse>> BuscarHeroPorNome(string nome);
    }
}
